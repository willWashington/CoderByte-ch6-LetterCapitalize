using System;
using System.Globalization;

namespace CoderByte_LetterCapitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the C# language, have the function LetterCapitalize(str) take the str parameter being passed and capitalize the first letter of each word. 
            //Words will be separated by only one space. 

            Console.WriteLine(LetterCapitalize("hello my name is pants"));
            Console.ReadLine();
        }

        static string LetterCapitalize(string str)
        {
            string capitalized = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            return capitalized;
        }
    }
}
