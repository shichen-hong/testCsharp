using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace testC_
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Hello testC -- " + DateTime.Now;
            
            consoleExample aConsoleExample = new consoleExample();
            aConsoleExample.example();

            myClasses.GenericList<int> cls = new myClasses.GenericList<int>();
            Console.WriteLine(cls.Max(1, 2));
            Console.ReadLine();
        }
    }

    class consoleExample
    {
        public void example()
        {
            myFunctions func = new myFunctions();
            Console.WriteLine("Please write a line:");
            Console.Beep();
            string myLine;
            do {
                myLine = Console.ReadLine();
                Console.WriteLine("Your input: {0}", myLine);
                Console.WriteLine("Your input is parsed to: {0}", func.stringParseInt(myLine));
            } while (myLine != "");
            Console.WriteLine("Functions run {0} times. End of program", func.ctr);
        }
    }

    class myFunctions
    {
        public int ctr = 0;
        public int stringParseInt(string input)
        {
            ctr++;
            try
            {
                return Convert.ToInt32(input);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Invalid input, {0}", e.Message);
                return -1;
            }
        }

        public void printArray(Array arr)
        {
            ctr++;
        }
    }
}
