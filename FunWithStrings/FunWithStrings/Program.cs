using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringsAreImmutable();
            ComparingStrings();
            StringsHaveLengthAndIndexes();
            CasingAndWhiteSpace();
            UsefulCharacterMethods();
            EditingStrings();
            SplitandJoin();
        }

        static void StringsAreImmutable()
        {
            string s1 = "Hello";

            s1.ToUpper();
            Console.WriteLine("s1: {0}", s1);

            s1 = s1.ToUpper();
            Console.WriteLine("s1: {0}", s1);

            Console.ReadLine();
            Console.Clear();
        }

        static void ComparingStrings()
        {
            string s1 = "hi";
            string s2 = "HI";

            if (s1 != s2)
            {
                Console.WriteLine("S1 is not equal to S2");
            }

            if(s1.Equals(s2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("S1 is equal to S2");
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void StringsHaveLengthAndIndexes()
        {
            string name = "Babatunde";

            Console.WriteLine("First letter: {0}", name[0]);

            for(int i=name.Length-1; i>=0; i--)
            {
                Console.Write("{0}", name[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Everything at or after position 1: {0}", name.Substring(1));

            Console.WriteLine("The last 2 characters: {0}", name.Substring(name.Length - 2, 2));

            Console.ReadLine();

            Console.Clear();
        }

        static void CasingAndWhiteSpace()
        {
            string s1 = "";
            Console.WriteLine("Does the string have data? {0}", string.IsNullOrEmpty(s1));

            s1 = "ABCdEfG";
            Console.WriteLine("{0} Toupper: {1} Tolower: {2}", s1, s1.ToUpper(), s1.ToLower());

            Console.ReadLine();

            Console.Clear();
        }

        static void UsefulCharacterMethods()
        {
            char c1 = 'a';

            Console.WriteLine("The character: {0}", c1);
            Console.WriteLine("IsDigit: {0}", char.IsDigit(c1));
            Console.WriteLine("IsLetter: {0}", char.IsLetter(c1));
            Console.WriteLine("IsLetterOrDigit: {0}", char.IsLetterOrDigit(c1));
            Console.WriteLine("IsLower: {0}", char.IsLower(c1));
            Console.WriteLine("IsUpper: {0}", char.IsUpper(c1));
            Console.WriteLine("IsPunctuation: {0}", char.IsPunctuation(c1));
            Console.WriteLine("IsWhitespace: {0}", char.IsWhiteSpace(c1));

            Console.ReadLine();
            Console.Clear();
        }

        private static void EditingStrings()
        {
            string s1 = "   Got some extra spaces?   ";
            s1 = s1.Trim();

            Console.WriteLine(s1);

            s1 = s1.Replace("Got", "Have");
            Console.WriteLine(s1);

            Console.ReadLine();
            Console.Clear();
        }

        static void SplitandJoin()
        {
            string s1 = "This is a sentence";

            string[] words = s1.Split(' ');

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            string s2 = string.Join(",", words);
            Console.WriteLine(s2);

            Console.ReadLine();
            Console.Clear();
        }
    }
}
