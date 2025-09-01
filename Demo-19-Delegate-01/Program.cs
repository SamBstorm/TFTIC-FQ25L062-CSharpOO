namespace Demo_19_Delegate_01
{
    delegate void DelegateMath(int x, int y);
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateMath math = Addition;
            math += Addition;
            math += Soustraction;
            math += Addition;
            math += Multiplication;
            math += Multiplication;
            math += Addition;
            math += Division;
            math -= Addition;
            math -= Multiplication;
            math -= Soustraction;
            math -= Soustraction;

            //if(math is not null)
            //{
            //    math(2, 3);
            //}

            math?.Invoke(2, 3);
        }

        static void Addition (int nb1, int nb2)
        {
            Console.WriteLine(nb1+nb2);
        }
        static void Multiplication(int nb1, int nb2)
        {
            Console.WriteLine(nb1 * nb2);
        }
        static void Soustraction(int nb1, int nb2)
        {
            Console.WriteLine(nb1 - nb2);
        }
        static void Division(int nb1, int nb2)
        {
            Console.WriteLine(nb1 / nb2);
        }
    }
}
