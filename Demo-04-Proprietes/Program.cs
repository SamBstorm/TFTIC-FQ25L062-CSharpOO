namespace Demo_04_Proprietes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginInformations li = new LoginInformations()
            {
                Login = "samuel.legrain@bstorm.be"
            };
            li.Password = "Toto";
            li.Password = "   Test1234=     ";
            li.Password = "ArthurDeMontMiraille";

            Console.WriteLine($"Voici vos informations de connection :\nLogin :\t{li.Login}\nMot de passe :\t{li.Password}");
        }
    }
}
