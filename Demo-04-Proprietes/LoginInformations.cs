using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04_Proprietes
{
    internal class LoginInformations
    {
        public string Login { get; set; }

        private string _password;

        public string Password
        {
            get {
                return "********";
            }
            set {
                if (!string.IsNullOrEmpty(this._password)) return;
                if (string.IsNullOrWhiteSpace(value)) return;
                value = value.Trim();
                if (value.Length < 8 || value.Length > 256) return;
                this._password = value;
            }
        }

        /*public void SetNewPassword(string newPassword)
        {
            this._password = newPassword;
        }*/

        public bool CheckLoginAndPassword(string login, string password)
        {
            return (Login == login) && (_password == password);
        }

    }
}
