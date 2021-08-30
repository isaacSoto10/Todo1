using System;

namespace program
{
    class Program
    {
        static string removeBlancks(string str)
        {
            string removed = str.Replace(" ", "");
            return removed;
        }
        static int GetDigit(string str)
        {
            string str2 = string.Empty;
            int val = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    str2 += str[i];
                }
           
            }
            if (str2.Length > 0)
            {
                val = int.Parse(str2);
            }   
            return val;

        }
        static string Acronyms(string str)
        {
            char[] tempArray = new char[str.Length];
            string abbr="";
            int loop = 0;
            
            
            tempArray = str.ToCharArray();

            abbr += (char)((int)tempArray[0] ^ 32);
            abbr += '-';

            for (loop = 0; loop < str.Length - 1; loop++)
            {
                if (tempArray[loop] == ' ' || tempArray[loop] == '\t' || tempArray[loop] == '\n')
                {

                    abbr += (char)((int)tempArray[loop + 1] ^ 32);
                    abbr += '-';
                }
            }

            return abbr;
        }
        static int countNonSpaces(string str)
        {
            string nospaces = str.Replace(" ", "");
            return nospaces.Length;
        }
        static string[] stringlessthan(string[] str, int value)
        {
            for(int i = 0; i < str.Length; i++)
            {
                int temp = (str[i].Length);
                if(temp > value)
                {
                     Console.WriteLine(str[i]);
                }
            }

            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(removeBlancks("paosdpfo apsodf "));
            Console.WriteLine("----------------------");
            Console.WriteLine(GetDigit("12ksls3"));
            Console.WriteLine("----------------------");
            Console.WriteLine(Acronyms("ASDjhsd kajsdfhksajd AKSJDFHAKSDJH alsdkfalsdk LAKSDJFLASKDFJ asldkfjlasdkj ALDKFJALSDK lasdlkf"));
            Console.WriteLine("----------------------");
            Console.WriteLine(countNonSpaces("lasdkslfdk asdlkfk dkdkkd"));
            Console.WriteLine("----------------------");

        }
    }
}
