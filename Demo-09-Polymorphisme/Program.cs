namespace Demo_09_Polymorphisme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero h = new();

            ObjetEquipement epee = new()
            {
                Nom = "Epée enflammée",
                Quantite = 1,
                EstEquipe = false
            };

            ObjetSoin potions = new()
            {
                Nom = "Potion",
                Quantite = 3
            };

            ObjetQuete cle = new()
            {
                Nom = "Cle du donjon"
            };

            h.Loot(cle);
            h.Loot(potions);
            h.Loot(epee);

            foreach (ObjetInventaire obj in h.Inventaire)
            {
                /* Ancienne méthode de test
                if(obj is ObjetQuete)
                {
                    ObjetQuete oq = (ObjetQuete)obj;
                    Console.WriteLine(oq.Nom);

                }
                else if(obj is ObjetEquipement)
                {
                    ObjetEquipement eq = (ObjetEquipement)obj;
                    Console.WriteLine($"{eq.Nom} [{((eq.EstEquipe)?"X":" ")}] x {eq.Quantite}");
                }
                else if (obj is ObjetSoin)
                {
                    ObjetSoin soin = (ObjetSoin)obj;
                    Console.WriteLine($"{soin.Nom} x {soin.Quantite}");
                    }*/
                /*Nouvelle méthode de test
                if (obj is ObjetQuete oq)
                {
                    Console.WriteLine(oq.Nom);
                }
                else if (obj is ObjetEquipement eq)
                {
                    Console.WriteLine($"{eq.Nom} [{((eq.EstEquipe) ? "X" : " ")}] x {eq.Quantite}");
                }
                else if (obj is ObjetSoin soin)
                {
                    Console.WriteLine($"{soin.Nom} x {soin.Quantite}");
                }*/
                /* Nouvelle méthode de test à l'aide d'un switch */
                switch (obj){
                    case ObjetQuete oq:
                        Console.WriteLine(oq.Nom);
                        break;
                    case ObjetEquipement eq:
                        Console.WriteLine($"{eq.Nom} [{((eq.EstEquipe) ? "X" : " ")}] x {eq.Quantite}");
                        break;
                    case ObjetSoin soin:
                        Console.WriteLine($"{soin.Nom} x {soin.Quantite}");
                        break;
                }
            }
        }
    }
}
