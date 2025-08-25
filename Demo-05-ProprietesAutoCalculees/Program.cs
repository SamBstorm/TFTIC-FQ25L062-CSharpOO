namespace Demo_05_ProprietesAutoCalculees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User sam = new()
            {
                BirthDate = new DateOnly(1987, 9, 27)
            };
            Console.WriteLine(sam.YearsOld);

            sam.BirthDate = new DateOnly(1989, 6, 21);
            Console.WriteLine(sam.YearsOld);

            sam.BirthDate = new DateOnly(1991, 12, 15);
            Console.WriteLine(sam.YearsOld);

        }
    }
}
