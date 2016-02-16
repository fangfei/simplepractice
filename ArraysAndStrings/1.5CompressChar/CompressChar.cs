using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5CompressChar
{
    class CompressChar
    {
        static void Main(string[] args)
        {            
            System.Console.WriteLine(CompressStr(args[0]));
        }

        private static string CompressStr(string str)
        {
            StringBuilder retStrBuilder = new StringBuilder();

            char currentCheckingChar = str[0];
            int currentCheckingCharCount = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == currentCheckingChar)
                {
                    currentCheckingCharCount++;
                }
                else
                {
                    retStrBuilder.Append(currentCheckingChar);
                    retStrBuilder.Append(currentCheckingCharCount);
                    currentCheckingChar = str[i];
                    currentCheckingCharCount = 1;
                }
            }

            retStrBuilder.Append(currentCheckingChar);
            retStrBuilder.Append(currentCheckingCharCount);

            string retStr = retStrBuilder.ToString();
            if (retStr.Length >= str.Length)
            {
                return str;
            }
            else
            {
                return retStr;
            }
        }
    }
}
