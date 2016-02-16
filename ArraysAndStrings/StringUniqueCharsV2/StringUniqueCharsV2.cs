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
            if (str.Length > 256)
            {
                return false;
            }

            bool[] char_uniqueattribute = new bool[256];
            for (int i = 0; i < str.Length; i++)
            {
                int charvalue = (int)str[i];
                if (char_uniqueattribute[charvalue])
                {
                    return false;
                }
                char_uniqueattribute[charvalue] = true;
            }
            return true;
        }
    }
}
