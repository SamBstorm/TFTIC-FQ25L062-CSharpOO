namespace Demo_12_Interface_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture v = new()
            {
                Immatriculation = "1-ABC-123",
                NbRoues = 4
            };
            v.Rouler(15);

            Velo ve = new();

            Personne p = new()
            {
                MoyenLocomotion = v
            };

            p.SeDeplacer(0, 0, 3, 4);

            p.MoyenLocomotion = ve;

            p.SeDeplacer(0, 0, 3, 4);
        }
    }
}
