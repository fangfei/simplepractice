using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8StringRotation
{
    class StringRotation
    {
        static void Main(string[] args)
        {
        }

        private static bool isRotate(string s1, string s2)
        {
            if (string.IsNullOrEmpty(s1))
            {
                return false;
            }

            int s1Len = s1.Length;
            if (string.IsNullOrEmpty(s2))
            {
                return true;
            }

            if (s1Len == s2.Length && s1Len > 0)
            {
                string s1s1 = s1 + s1;
                return s1s1.Contains(s2);
            }

            return false;
        }
    }
}
