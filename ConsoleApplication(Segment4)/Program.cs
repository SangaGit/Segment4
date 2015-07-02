using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Segment4_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> NameList = new List<string>() { "Sangeeth", "Akila", "Chathura", "Chanaka", "Saman" };
            Console.WriteLine("Enter the Character You want.");
            char c = Convert.ToChar(Console.ReadLine());
            Sort(NameList, c);
            Console.Read();
        }
        public static List<string> Sort(List<string> theList, char theChar)
        {
            for (int i = 0; i < theList.Count; i++)
            {
                string Name = theList[i];               //string Name = theList[i][0].ToString();
                string FirstChar = Name[0].ToString();
                if (Name[0] == theChar || Name[0] == char.ToUpper(theChar))
                {
                    Console.WriteLine(theList[i]);
                }
                //    
                //    if (FirstChar.Contains(theChar))
                //    {
                //        Console.WriteLine(theList[i]);
                //    }
                //    else if (theList[i] == null)
                //    {
                //        Console.WriteLine("There is no Name begin with character - " + theChar);
                //    }
            }

            return theList;
        }

    }
}
