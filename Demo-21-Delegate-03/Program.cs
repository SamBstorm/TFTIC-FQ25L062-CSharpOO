using Demo_21_Delegate_03.Models;

namespace Demo_21_Delegate_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eleve e1 = new("Morre", "Thierry");
            e1.AjouterNote(20);
            e1.AjouterNote(17.5);
            e1.AjouterNote(18.5);

            Eleve e2 = new("Person", "Michael");
            e2.AjouterNote(14);
            e2.AjouterNote(17.5);
            e2.AjouterNote(20);

            Eleve e3 = new("Chaineux", "Gavin");
            e3.AjouterNote(12);
            e3.AjouterNote(12.5);
            e3.AjouterNote(14);

            CahierNotes cn = new();

            cn.AjouterEleve(e1);
            cn.AjouterEleve(e2);
            cn.AjouterEleve(e3);

            cn.AfficherSommes();
        }
    }
}
