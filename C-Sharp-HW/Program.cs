using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World",str2 = "Hello", str3 = "Check";
            Console.WriteLine(str.Contains(str2)); // checks if str containes str2 - returns true/false
            char[] arr = new char[10];
            str.CopyTo(1,arr, 0,5); // copies a specified number of characters from a specified position in this instance to a specified position into a char array)
            Console.WriteLine(arr);
            
            Console.WriteLine(str.Insert(2, str3)); // Returns a new string in which a specified string is inserted in a specified index position in this instance
            str3 = str.PadRight(20); // returns a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length
            Console.WriteLine(str3 + "Check");
            
            Console.WriteLine(str.Replace('l', 'k')); // returns a new string in which all occurrences of a specified character in this instace are replaced with another specified character
            str3 = str.Substring(4);
            Console.WriteLine(str3); //retrieves a substring from this instance. the substring starts at a specified character position and continues to the end of the string
            char[] arr2 = str.ToCharArray(); // copies the character in this instance to a character array
            string[] strArr = str.Split('o'); // splits a string into substrings that are based on the characters in an array 
            Console.WriteLine(str.Trim('H', 'e'));//removes all leading and trailing white-space characters from the current String object - garbge function
            string str4 = "****0000ABC0000****";
            Console.WriteLine(str4.TrimStart('0','*')); //remove the occurrences of a set of characters specified in an array from the starting of the current String object
            Console.WriteLine(str.StartsWith("He"));//check whether the beginning of the current string instance matches with a specified string or not
            Console.WriteLine(str.IndexOf('l', str.IndexOf('l')+2)); //used to find the zero-based index of the first occurrence of a specified character or string within the current instance of the string
            Console.WriteLine(switchSubWithAsterisk("Hello ello ll", "ll"));
            Console.ReadLine();
            string switchSubWithAsterisk(string original, string subString)
            {
                string temp;
                temp = original.Replace(subString, "*");
                return temp;
            }
        }

    }
}
