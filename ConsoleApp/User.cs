using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class User
    {
        private List<int> score = new List<int>();
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public void AddScore(int score)
        {
            this.score.Add(score);
        }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
}
