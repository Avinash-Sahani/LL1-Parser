using System;
using System.Collections.Generic;
using System.Linq;
using Parser;
using Parser.Parser_LL1_;
namespace ParserA1
{
    class Tester
    {
        static void Main(string[] args)
        {
           ComputeQuery query = new ComputeQuery();
            //Sample Test Cases
            Console.WriteLine("Sample Test Cases: ");
            Console.WriteLine( query.SolveQuery("3+5+9"));
            Console.WriteLine(query.SolveQuery("9-1+2"));
            Console.WriteLine(query.SolveQuery("4+3*5"));
            Console.WriteLine(query.SolveQuery("9/3-2"));
            Console.WriteLine(query.SolveQuery("(9*2)-(2*4+2)"));
            Console.WriteLine(query.SolveQuery("7+2-(3*7+6)"));
            Console.WriteLine(query.SolveQuery("7-2+(8*7)"));
            Console.WriteLine(query.SolveQuery("8+9+(3*7*(2*3))"));


            //User Input
            Console.WriteLine("\n Imortant Instruction ");
            Console.WriteLine("1- Do Avoid WhiteSpaces");
            Console.WriteLine("2- Num Length should be 1 (0-9)");
            Console.Write("\n Input Expression : ");
            Console.WriteLine(query.SolveQuery(Console.ReadLine().Trim()));
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}

