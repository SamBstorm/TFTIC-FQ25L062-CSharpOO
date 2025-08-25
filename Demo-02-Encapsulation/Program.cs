using Demo_02_Encapsulation.Structs;

namespace Demo_02_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginInformations li = new LoginInformations();

            li.login = "samuel.legrain@bstorm.be";
            //li._password = "Test1234=";

            //Console.WriteLine($"Voici vos informations de connection :\nLogin :\t{li.login}\nMot de passe :\t{li._password}");

            li.SetNewPassword("Test1234=");
            Console.WriteLine($"Voici vos informations de connection :\nLogin :\t{li.login}");

            Console.Clear();
            Console.WriteLine("Bonjour, veuillez introduire votre login :");
            string userLogin = Console.ReadLine();
            Console.WriteLine("et maintenant, le mot de passe :");
            string userPassword = Console.ReadLine();
            Console.Clear();
            if(li.CheckLoginAndPassword(userLogin, userPassword))
            {
                Console.WriteLine("Bienvenue!");
            }
            else
            {
                Console.WriteLine("Erreur d'authentification!");
            }
        }
    }
}
