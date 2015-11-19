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
        private string filePath = @"./statistics.json"; //Path to statistics file
        private JObject jsonObject = new JObject(); //An object to store statistics and user info
        private List<User> users = new List<User>(); //List of users
        private StreamWriter fileWriter = null; //Filewriter - could be local, but want to avoid memory fractionation of memory (habbits from embedded c/c++)
        private StreamReader fileReader = null; //Filereader ----------------------------------------||-------------------------------------------------------
        private User currentUser = null; //Current user playing the game

        /*
        Brukerne er ikke passordbeskyttet ettersom det er litt merkelig for et slikt spill. Det kan dog lett legges ved å gi User-klassen et variabel for passord og
        legge den variabelen til i JSON objektet (likt som med brukernavnet) når brukeren lagres. Ellers er det bare å legge til en if for å sjekke om oppgitt passord er lik det lagrede passordet. 

        JSON ble brukt for å gjøre det lettere å organisere informasjoen. Om mer brukerinfo skal legges til er det bare å legge til elementer i json objektet. Det gjør det lettere å endre koden senere.
            */

        public Statistics()
        {
            InitializeComponent();
            if (!File.Exists(filePath)) //Create file if it doesent exist
            {
                File.Create(filePath).Close();
            }
            loadFromFile(); //Load users and statistics from file
            loadScoreboard(); //Get scoreboard from all users
            usernameTextbox.Focus(); //Focus on textbox
        }

        private void btn_gamstart_Click(object sender, EventArgs e)
        {
            if (currentUser != null) //If user selected - start game
            {
                new Form1(this).ShowDialog();
            }
            else //If no user selected - prompt user
            {
                MessageBox.Show("Select user before starting the game", "Warning");
            }
        }

        public void loadFromFile()
        {
            fileReader = new StreamReader(filePath); //Open file
            string jsonString = fileReader.ReadLine(); //file contains one line only by design (ends with \n) - json formatting
            fileReader.Close(); //Close file - avoid file exceptions
            fileReader.Dispose();
            if (jsonString != null && jsonString.Length > 0) //If string exist
            {
                JObject jsonObject = JObject.Parse(jsonString); //Parse string into jsonobject for easier manipulation
                JArray users = jsonObject.GetValue("users") as JArray; //Get user array from jsonobject
                if (users != null)
                {
                    foreach (JObject u in users) //Add users to users list
                    {
                        User user = new User(u.GetValue("username").ToString());
                        JArray score = u.GetValue("scoreboard") as JArray;
                        user.loadScoreboardArray(score.ToObject<int[]>());
                        bool userExcist = false; //If user exist - refresh scoreboard
                        foreach (User ue in this.users)
                        {
                            if (ue.getUsername().CompareTo(user.getUsername()) == 0)
                            {
                                userExcist = true;
                                ue.loadScoreboardArray(score.ToObject<int[]>());
                                break;
                            }
                        }
                        if (!userExcist) //If user doesent exist - add 
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
            foreach(User u in this.users) //Add users to user array
            {
                JObject user = new JObject();
                user.Add("username", u.getUsername());
                JArray score = new JArray(u.getScoreboardArray());
                user.Add("scoreboard", score);
                users.Add(user);
            }
            toWrite.Add("users", users); //Add users to jsonobject
            fileWriter = new StreamWriter(filePath); //Open file
            fileWriter.WriteLine(toWrite.ToString(Formatting.None)); //Write one line (Formatting.None - toString should add any line ending characters)
            fileWriter.Close(); //Close file
            fileWriter.Dispose();

        }

        private void btn_getuser_Click(object sender, EventArgs e)
        {
            if (usernameTextbox.Text.Length > 0)
            {
                loadFromFile(); //Reload
                foreach(User u in users) //Check if user exsist
                {
                    if(u.getUsername().CompareTo(usernameTextbox.Text) == 0)
                    {
                        currentUser = u;
                        statisticsBox.DataSource = u.getScoreboardArray();
                        currentUserLabel.Text = u.getUsername();
                        return; //Function returns here (stops)
                    }
                    
                }
                //This only runs if user not found
                User user = new User(usernameTextbox.Text);
                currentUser = user;
                users.Add(user);
                statisticsBox.DataSource = user.getScoreboardArray(); //Show user scoreboard
                currentUserLabel.Text = user.getUsername();
                writeToFile(); //Write changes to file
            }
        }

        //Form1 (the game) needs a public function to transfer score to this form
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

        //Get highest score from each users and adds it to the view
        private void loadScoreboard()
        {
            Dictionary<string, int> scoreboard = new Dictionary<string, int>();
            
            foreach(User u in users)
            {
                if (u.getScoreboardArray().Length > 0)
                {
                    scoreboard.Add(u.getUsername(), u.getScoreboardArray()[0]);
                }
            }
            scoreboard = scoreboard.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            scoreboardList.DataSource = new BindingSource(scoreboard, null);

        }
    }
}
