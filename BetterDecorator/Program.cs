using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = args[0];

            string str1 = args[1];
            char letter = str1[0];

            string str2 = args[2];
            int num = int.Parse(str2);

            Console.WriteLine(Decor(phrase, letter, num));



        }
        /// <summary>
        /// Print 
        /// </summary>
        /// <param name="s">phrase</param>
        /// <param name="dec">Hwhich character to print</param>
        /// <param name="a">How many times should print before and after</param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int a)
        {
            string result = "";

            for (int i = 0; i < a; i++)
            {
                result += dec;
            }

            result += " ";

            result += s;

            result += " ";

            for (int j = 0; j < a; j++)
            {
                result += dec;
            }

            return result;
        }
    }
}
