using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.Parser_LL1_
{
    class ComputeQuery
    {


        public int SolveQuery(string input)
        {
            int output = -1;
            try
            {
                //Lexical Analysis
                Lexer lexer = new Lexer(input);
                var Tokens = lexer.Tokens;

                //Parser
                LLParser parser = new LLParser(Tokens);
                var ParseTree = parser.ParseExprssion();

                //Solve Parse Tree
                ExpressionSolver solver = new ExpressionSolver();
                output = solver.SolveExpression(ParseTree);


            
                    }

            catch(Exception e)
            {

                Console.WriteLine(e.ToString());
            }
            return output;
        }

    }
}
