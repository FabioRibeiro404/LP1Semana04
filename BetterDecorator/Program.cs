using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "";
            string str1 = "";
            string str2 = "";

            if (args.Length != 0)
            {
                phrase = args[0];

                str1 = args[1];
                char letter = str1[0];

                str2 = args[2];
                int num = int.Parse(str2);

            
            
                Console.WriteLine(Decor(phrase, letter, num));
            }
            else
            {
                Console.WriteLine(Decor());
            }
            

        }
        /// <summary>
        /// Print 
        /// </summary>
        /// <param name="s">phrase</param>
        /// <param name="dec">Which character to print</param>
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

        private static string Decor()
        {
            string empty = "User did not specify args!";
            string str3 = "=";
            char repeat = str3[0];
            int num1 = 3;
            //Console.Write("hello");
            return Decor(empty, repeat, num1);
        }
    }
}
