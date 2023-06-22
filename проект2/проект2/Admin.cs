using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект2
{
    class Admin
    {
        public int Id { get; set; }
        private string pass, login;
        public string Pass
        {
            get { return pass; }
            set { pass= value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public Admin() { }
        public Admin(string pass, string login)
        {
            this.pass = pass;
            this.login = login;
        }
    }
}