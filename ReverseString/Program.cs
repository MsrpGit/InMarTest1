using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdef";
            string reversestr = "";

            int length = str.Length - 1;

            while (length >= 0)
            {
                reversestr = reversestr + str[length];
                length = length - 1;
            }
            Console.WriteLine(reversestr);
            Console.Read();
        }
    }
}
