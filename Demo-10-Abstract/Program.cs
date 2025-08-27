namespace Demo_10_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animaux = new();

            animaux.Add(new Chien()
            {
                Nom = "Médor"
            });
            animaux.Add(new Chat()
            {
                Nom = "Félix"
            });

            animaux.Add(new Chien()
            {
                Nom = "César"
            });
            animaux.Add(new Chat()
            {
                Nom = "Wiskass"
            });

            foreach (Animal a in animaux)
            {
                a.Crier();
            }
        }
    }
}
