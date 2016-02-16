using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUniqueChars
{
    class CheckingStringUniqueChars
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(args[0]);
            if (isUniqueChars(args[0]))
            {
                System.Console.WriteLine("IS Unique");
            }
            else
            {
                System.Console.WriteLine("NOT Unique");
            }
        }

        private static bool isUniqueChars(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char c1 = str[i];
                for (int j = 0; j < str.Length; j++)
                {
                    char c2 = str[j];
                    if ((i != j) && (c1 == c2))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
