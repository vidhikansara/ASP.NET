using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesString
{
    public delegate string ConcateStrings(string str1,string str2);
    public delegate void ReverseString(string str);

    public class ApplyString
    {
        public static string strconcate(string s1,string s2)
        {
            string con = String.Concat(s1, s2);
            return con;
        }

        public static void strreverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.WriteLine("Enter first string : ");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second string : ");
            str2 = Console.ReadLine();

            ConcateStrings con = new ConcateStrings(ApplyString.strconcate);
            Console.WriteLine("Concate of strings : "+con(str1,str2));
            ReverseString rev = new ReverseString(ApplyString.strreverse);
            rev(str1);
            Console.ReadKey();
        }
    }
}
