namespace Demo_22_Delegate_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompactDisk cd1 = new("Compil de l'été 2025",
                [
                    new("David Getta", "I'm blue", 178000),
                    new("Nobuo Uematsu", "Zanarkand", 210000),
                    new("Eddy Mitchell", "La route de Memphis", 180000),
                    new("Radiohead", "Nude", 300000),
                    new("Le grand Jojo","Chef, un p'tit verre on à soif!", 200000),
                    new("Renaud", "Mistral gagnant", 160000)
                ]);

            CDPlayer lecteur = new();

            lecteur.CurrentCD = cd1;

            lecteur.AjouterProgramme(2);
            lecteur.AjouterProgramme(1);
            lecteur.AjouterProgramme(3);
            lecteur.AjouterProgramme(4);
            lecteur.AjouterProgramme(3);
            lecteur.AjouterProgramme(6);
            lecteur.AjouterProgramme(5);

            lecteur.Play();
        }
    }
}
