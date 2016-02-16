using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringV1
{
    class ReverseStringV1
    {
        static void Main(string[] args)
        {
            string strOri = args[0];
            string strRev = reversestr(strOri);
            System.Console.WriteLine(strRev);
        }

        private static string reversestr(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            char[] array = str.ToCharArray();
            //Array.Reverse(array);

            for (int i = 0; i < str.Length / 2; i++)
            {
                char tmp = array[i];
                array[i] = array[str.Length - i - 1];
                array[str.Length - i - 1] = tmp;
            }

            return new String(array);
        }
    }
}
