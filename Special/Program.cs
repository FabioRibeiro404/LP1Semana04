using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            Console.WriteLine(GetSpecial(num));
        }
        private static int GetSpecial(int n)
        {
            int result;
            if (n == 0)
                result = 0;
            else if (n == 1 || n == 2)
                result = 1;
            else
            {
                result = GetSpecial(n - 2) + (2 * GetSpecial(n - 1));
            }

            return result;
        }
    }
}
