using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Actionspill
{
    public partial class Form1 : Form
    {
        //Statistics
        private int points = 0;
        //Movement
        private bool movementRight = false;
        private Timer moveTimer = new Timer();
        //Enemies
        private PictureBox[] enemies = new PictureBox[5];
        private Timer enemyTimer = new Timer();
        //Shooting
        private List<Panel> shotsFired = new List<Panel>();
        private Timer shotTimer = new Timer();
        //User interface
        private bool isPaused = false;
        private bool isGameOver = false;

        private Statistics statForm = null;

        public Form1(Statistics stats)
        {
            InitializeComponent();
            initiateVariables();
            statForm = stats;
            
        }

        private void initiateVariables()
        {
            moveTimer.Tick += MoveTimer_Tick;
            moveTimer.Interval = 1; //Movement velocity
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = 500; //Popupspeed of enemies
            enemyTimer.Start();
            shotTimer.Tick += ShotTimer_Tick;
            shotTimer.Interval = 2; //Bullet velocity
            shotTimer.Start();
            hitCounter.Text = points.ToString();
            emil1.Parent = emil2.Parent = emil3.Parent = emil4.Parent = emil5.Parent = carImage;
            emil1.Top = emil2.Top = emil3.Top = emil4.Top = emil5.Top = emil1.Top - 140;
            enemies[0] = emil1;
            enemies[1] = emil2;
            enemies[2] = emil3;
            enemies[3] = emil4;
            enemies[4] = emil5;
        }

        #region TIMEREVENTS
        private void ShotTimer_Tick(object sender, EventArgs e)
        {
            foreach (Panel s in shotsFired.ToArray())
            {
                s.Top += 5;
                foreach (PictureBox enemy in enemies)
                {
                    if (collision(s, enemy) && enemy.Visible)
                    {
                        enemy.Visible = false;
                        shotsFired.Remove(s);
                        this.Controls.Remove(s);
                        hitCounter.Text = (++points).ToString();
                    }
                    else if (s.Top >= this.Height)
                    {
                        this.Controls.Remove(s);
                        this.shotsFired.Remove(s);
                    }
                }
            }
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            int enemyNum = new Random().Next(0, enemies.Length);
            enemies[enemyNum].Visible = true;
            foreach (PictureBox enemy in enemies)
            {
                if (enemy.Visible == false)
                {
                    return;
                }
            }
            gameOver();
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if (movementRight && player.Right <= this.Width)
            {
                player.Left += 5;
            }
            else if (!movementRight && player.Left >= 0)
            {
                player.Left -= 5;
            }
        }
        #endregion
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }

        #region KEYBOARD
        private void keyEvent(object sender, KeyEventArgs e)
        {
            if (!isPaused && !isGameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        movementRight = true;
                        moveTimer.Start();
                        break;
                    case Keys.Left:
                        movementRight = false;
                        moveTimer.Start();
                        break;
                    case Keys.Space:
                        fireShot();
                        break;

                }
            }
        }

        private void KeyPress_Event(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'p':
                    pause();
                    break;
                case 'r':
                    restart();
                    break;


            }
        }

        private void KeyUp_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !movementRight || e.KeyCode == Keys.Right && movementRight)
            {
                moveTimer.Stop();
            }
        }
        #endregion

        #region GAMELOGIC
        //Fire a shot
        private void fireShot()  
        {
            Panel shot = new Panel();
            shot.BackColor = Color.Black;
            shot.Size = new Size(20, 20);
            shot.Top = player.Bottom;
            shot.Left = player.Right;
            this.Controls.Add(shot);
            shot.BringToFront();
            shotsFired.Add(shot);
        }
        private bool collision(Panel shot, PictureBox enemy)
        {
            Point enemyPoint = enemy.FindForm().PointToClient(enemy.Parent.PointToScreen(enemy.Location)); //Get absolute position of control in window
            return shot.Right >= enemyPoint.X - (enemy.Width / 2) + 5 && shot.Left <= enemyPoint.X + (enemy.Width / 2) + 20 && shot.Bottom >= enemyPoint.Y - (enemy.Height / 2) + 50 && shot.Top <= enemyPoint.Y + (enemy.Height / 2); //Checks if the shot is within the enemy boundries
        }
        #endregion
        
        //Pause game
        private void pause()
        {
            if (!isPaused)
            {
                moveTimer.Stop();
                shotTimer.Stop();
                enemyTimer.Stop();
                statusLabel.Text = "PAUSE";
                statusLabel.Visible = true;
            }
            else
            {
                shotTimer.Start();
                enemyTimer.Start();
                statusLabel.Visible = false;
            }
            isPaused = !isPaused;
        }

        //Restart game
        private void restart()
        {
            this.Close();
        }

        //Game over
        private void gameOver()
        {
            statusLabel.Text = "GAME OVER";
            statusLabel.Visible = true;
            enemyTimer.Stop();
            shotTimer.Stop();
            isGameOver = true;
            statForm.addRun(points);
            
        }
    }
}