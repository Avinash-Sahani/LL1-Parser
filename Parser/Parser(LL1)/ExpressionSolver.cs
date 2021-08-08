using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.Parser_LL1_
{
    class ExpressionSolver
    {
   

        public int SolveExpression(LexerToken parseTree)
        {
            if (parseTree.Kind == LexerTokenKind.Integer)
                return Convert.ToInt32(parseTree.Text);

            else
            {


                LexerToken left_node = parseTree.childern[0];
                LexerToken right_node = parseTree.childern[1];
                int right_value;
                int left_value;
                if (isInt(left_node.Text))
                    left_value = Convert.ToInt32(parseTree.childern[0].Text);
                else
                    left_value = this.SolveExpression(left_node);


                if (isInt(right_node.Text))
                    right_value = Convert.ToInt32(parseTree.childern[1].Text);
                else
                    right_value = this.SolveExpression(right_node);
                
                LexerTokenKind opeartion = parseTree.Kind;
                int output = PerfromOperation(left_value, right_value, opeartion);
                return output;


            }


       
        }

        Boolean isInt(String text)
        {
            if (int.TryParse(text, out int n))
                return true;

           return false;
        }
        public int PerfromOperation(int left_value, int right_value, LexerTokenKind opeartion)
        {
            
            return opeartion switch
            {
                 LexerTokenKind.Plus => left_value + right_value ,
                 LexerTokenKind.Minus=> left_value - right_value,
                 LexerTokenKind.Asterisk => left_value  * right_value,
                 LexerTokenKind.Divide => left_value / right_value,
                _ => throw new Exception("Invalid Operand: " +opeartion.GetDescription())
            };
           
           
        }
    }
}
