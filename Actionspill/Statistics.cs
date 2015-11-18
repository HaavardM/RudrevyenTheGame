using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Actionspill
{
    public partial class Statistics : Form
    {
        private string filePath = @"./statistics.json";
        private JObject jsonObject = new JObject();
        private List<User> users = new List<User>();
        StreamWriter fileWriter = null;
        StreamReader fileReader = null;
        private User currentUser = null;

        public Statistics()
        {
            InitializeComponent();
            loadFromFile();
            loadScoreboard();
            usernameTextbox.Focus();
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
        }

        private void btn_gamstart_Click(object sender, EventArgs e)
        {
            new Form1(this).ShowDialog();
        }

        public void loadFromFile()
        {
            fileReader = new StreamReader(filePath);
            string jsonString = fileReader.ReadLine();
            fileReader.Close();
            fileReader.Dispose();
            if (jsonString != null && jsonString.Length > 0)
            {
                JObject jsonObject = JObject.Parse(jsonString);
                fileReader.Close();
                JArray users = jsonObject.GetValue("users") as JArray;
                if (users != null)
                {
                    foreach (JObject u in users)
                    {
                        User user = new User(u.GetValue("username").ToString());
                        JArray score = u.GetValue("scoreboard") as JArray;
                        user.loadScoreboardArray(score.ToObject<int[]>());
                        bool userExcist = false;
                        foreach (User ue in this.users)
                        {
                            if (ue.getUsername().CompareTo(user.getUsername()) == 0)
                            {
                                userExcist = true;
                                ue.loadScoreboardArray(score.ToObject<int[]>());
                                break;
                            }
                        }
                        if (!userExcist)
                        {
                            this.users.Add(user);
                        }

                    }
                }
            }
        }

        public void writeToFile()
        {
            JObject toWrite = new JObject();
            JArray users = new JArray();
            foreach(User u in this.users)
            {
                JObject user = new JObject();
                user.Add("username", u.getUsername());
                JArray score = new JArray(u.getScoreboardArray());
                user.Add("scoreboard", score);
                users.Add(user);
            }
            toWrite.Add("users", users);
            fileWriter = new StreamWriter(filePath);
            fileWriter.WriteLine(toWrite.ToString(Formatting.None));
            fileWriter.Close();
            fileWriter.Dispose();

        }

        private void btn_getuser_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text.Length > 0)
            {
                loadFromFile();
                foreach(User u in users)
                {
                    if(u.getUsername().CompareTo(usernameTextbox.Text) == 0)
                    {
                        currentUser = u;
                        statisticsBox.DataSource = u.getScoreboardArray();
                        currentUserLabel.Text = u.getUsername();
                        return;
                    }
                    
                }
                User user = new User(usernameTextbox.Text);
                currentUser = user;
                users.Add(user);
                statisticsBox.DataSource = user.getScoreboardArray();
                currentUserLabel.Text = user.getUsername();
            }
            writeToFile();

        }

        public void addRun(int points)
        {
            if (currentUser != null)
            {
                currentUser.addScore(points);
                this.statisticsBox.DataSource = currentUser.getScoreboardArray();
                writeToFile();
                loadScoreboard();
            }
        }

        private void loadScoreboard()
        {
            Dictionary<string, int> scoreboard = new Dictionary<string, int>();
            
            foreach(User u in users)
            {
                scoreboard.Add(u.getUsername(), u.getScoreboardArray()[0]);
            }
            scoreboard = scoreboard.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            scoreboardList.DataSource = new BindingSource(scoreboard, null);

        }
    }
}
