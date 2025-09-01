namespace Demo_23_Delegate_05
{
    delegate bool TryParseDelegate(string valueToConvert, out int converted);
    internal class Program
    {
        static void Main(string[] args)
        {
            TryParseDelegate tryParse = delegate (string userValue, out int resultConvert)
            {
                resultConvert = default;
                try
                {
                    resultConvert = int.Parse(userValue);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            };

            Console.WriteLine("Veuillez donner un chiffre :");

            if(tryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine($"La valeur est bien un nombre : {value}");
            }
            else
            {
                Console.WriteLine($"Ce n'est pas un nombre...");
            }
        }
    }
}
