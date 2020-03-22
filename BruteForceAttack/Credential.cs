using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceAttack
{
    class Credential
    {
        private string login;
        private string password;

        public string Password { get => password; set => password = value; }
        public string Login { get => login; set => login = value; }

        public Credential(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
