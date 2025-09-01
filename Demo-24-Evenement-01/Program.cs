using Demo_24_Evenement_01.Models;

namespace Demo_24_Evenement_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bucheron b = new();
            b.frappeEvent += NotifierBucheronFrappe;

            Arbre a1 = new();
            a1.chute += NotifierChuteArbre;
            Arbre a2 = new();
            a2.chute += NotifierChuteArbre;
            Arbre a3 = new();
            a3.chute += NotifierChuteArbre;

            b.frappeEvent += a1.Tomber;
            b.Frapper();
            b.frappeEvent -= a1.Tomber;

            b.frappeEvent += a2.Tomber;
            b.Frapper();
            b.frappeEvent -= a2.Tomber;

            b.frappeEvent += a3.Tomber;
            b.Frapper();
            b.frappeEvent -= a3.Tomber;

            Personne p = new Personne();
            p.blesseEvent += NotifierPersonneBlesse;

            //Mise en place de délégué anonyme pour adapter le type des événements :
            //Besoin d'un void sans paramètre, pour une méthode avec paramètre.
            b.frappeEvent += delegate() { p.SeBlesser(b); };
            b.Frapper();
            b.frappeEvent -= delegate () { p.SeBlesser(b); };
        }

        public static void NotifierChuteArbre()
        {
            Console.WriteLine("Un arbre est tombé!");
        }

        public static void NotifierBucheronFrappe()
        {
            Console.WriteLine("Le bucheron frappe avec sa hache!");
        }
        public static void NotifierPersonneBlesse(object agresseur, Personne agressee)
        {
            Console.WriteLine($"Le {agressee} est blessé par {agresseur}!");
        }
    }
}
