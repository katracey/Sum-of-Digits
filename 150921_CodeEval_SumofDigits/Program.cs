using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _150921_CodeEval_SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a positive integer, find the sum of its constituent digits.
            /*Sample code to read in test cases:
using System.IO;
using System.Collections.Generic;

class Program
{
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            // do something with line

        }
    }
}*/

            string line = "25";
            string[] myArray = new string[line.Length];
            int x = 0;

            for (int i = 0; i < line.Length; i++)
            {
               x += int.Parse(myArray[i] = line[i].ToString());               
            }
            Console.WriteLine(x);


        }
    }
}
