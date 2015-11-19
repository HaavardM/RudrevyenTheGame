using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actionspill
{
    class User
    {
        private string username;
        private List<int> scoreboard = new List<int>();

        public User(string name)
        {
            username = name;
        }
            
        public void addScore(int score)
        {
            scoreboard.Add(score);
            scoreboard.Sort(); //Sort - min to max
            scoreboard.Reverse();//Reverse - max to min
        }

        public int[] getScoreboardArray()
        {
            return scoreboard.ToArray();
        }

        public void loadScoreboardArray(int[] scoreboard)
        {
            this.scoreboard = new List<int>(scoreboard);
            this.scoreboard.Sort();
            this.scoreboard.Reverse();
        }

        public string getUsername()
        {
            return username;
        }
    }
}
