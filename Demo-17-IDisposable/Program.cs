namespace Demo_17_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (TalkieWalkie tw2 = new("Gérard"))
            {
                using (TalkieWalkie tw1 = new("Sam"))
                {
                    tw1.Parler("Bonjour!");
                    tw2.Parler("Salut! Comment vas-tu?");
                    tw1.Parler("Je vais bien et toi?");
                    tw2.Parler("Ca va! mais je crois que l'on nous écoute!");
                    tw1.Parler("Ok! A plus tard!");
                    tw2.Parler("À plus!");
                }
            }
        }
    }
}
