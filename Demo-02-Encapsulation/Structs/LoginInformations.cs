using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02_Encapsulation.Structs
{
    internal struct LoginInformations
    {
        public string login;

        private string _password;

        //La méthode public donne accès à notre variable privée:
        //La variable reste accèssible aux membres de sa class/struct
        public void SetNewPassword(string newPassword)
        {
            this._password = newPassword;
        }

        public bool CheckLoginAndPassword(string login, string password)
        {
            return (this.login == login) && (this._password == password);
        }
    }
}
