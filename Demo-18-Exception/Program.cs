using Demo_18_Exception.Models;
using Demo_18_Exception.Models.Exceptions;

namespace Demo_18_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Les Exceptions du système : exemple DivideByZeroException

            //int x = 10;
            //int y = 0;
            //try
            //{
            //    Console.WriteLine(x / y);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine($"L'opération {x}/{y} n'est pas possible...");
            //}

            #endregion

            #region Les Exceptions du système : exemple avec throw

            string log = null;
            try
            {
                Personne p1 = new Personne("Garcia", "Andy", new(2016, 1, 1));
                Console.WriteLine($"Voici {p1.Nom} {p1.Prenom}!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("La personne n'a pu être générée car des informations sont manquantes.");
                log = $"{DateTime.Now.ToShortTimeString()} ArgumentNullException";
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Vous n'avez pas l'âge requis...");
                Console.WriteLine(e.Message);
                if(e.InnerException is YearsOldLimitException yearExcept)
                {
                    Console.WriteLine($"StartDate : {yearExcept.StartDate}");
                    Console.WriteLine($"ExceptionDate : {yearExcept.ExceptionDate}");
                    Console.WriteLine($"Limit : {yearExcept.Limit}");
                    Console.WriteLine($"YearsOld : {yearExcept.YearsOld}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("La personne n'a pu être générée...");
                Console.WriteLine(e.Message);
                log = $"{DateTime.Now.ToShortTimeString()} Exception";
            }
            finally
            {
                Console.WriteLine(log);
            }


            #endregion
        }
    }
}
