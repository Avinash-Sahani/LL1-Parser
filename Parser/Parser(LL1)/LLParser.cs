using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Parser.Parser_LL1_
{
    class LLParser : ParserBase
    {
        public Stack<LexerToken> tokens = null;

        public LLParser(IEnumerable<LexerToken> Tokens)
        {
            tokens = new Stack<LexerToken>();
            tokens.Push(new LexerToken("$", LexerTokenKind.END)); //Dollar Sign to Determine End
            foreach (var t in Tokens.Reverse())
                tokens.Push(t);

        }
        public LexerToken ParseExprssion()
        {
            return ParseExpression1();
        }
        public override LexerToken ParseExpression1()
        {
            ParsingStruct exp1;


        exp1.currentToken = this.ParseExpression2(); // E - > E2

            exp1.currentTokenKind = tokens.Peek().Kind;
           
            while (exp1.currentTokenKind == LexerTokenKind.Plus  || exp1.currentTokenKind == LexerTokenKind.Minus)
            {

                exp1.ParentToken = tokens.Pop();
                exp1.leftchildToken = exp1.currentToken;
                exp1.ParentToken.childern.Add(exp1.leftchildToken);
                exp1.rightchildToken = this.ParseExpression2();
                exp1.ParentToken.childern.Add(exp1.rightchildToken);
               
                exp1.currentToken = exp1.ParentToken;
                exp1.currentTokenKind = tokens.Peek().Kind;
               

            }
            
            return exp1.currentToken;


            

        }

        public override LexerToken ParseExpression2()
        {
            ParsingStruct exp2;


            exp2.currentToken = ParseExpression3();  // E2 ->E3

            exp2.currentTokenKind = tokens.Peek().Kind;

            while (exp2.currentTokenKind == LexerTokenKind.Asterisk || exp2.currentTokenKind == LexerTokenKind.Divide)
            {

                exp2.ParentToken = tokens.Pop();
                exp2.leftchildToken = exp2.currentToken;
                exp2.ParentToken.childern.Add(exp2.leftchildToken);
                exp2.rightchildToken = this.ParseExpression3(); //E2 - > E3
                exp2.ParentToken.childern.Add(exp2.rightchildToken);
                exp2.currentToken = exp2.ParentToken;
                exp2.currentTokenKind = tokens.Peek().Kind;

            }

            return exp2.currentToken;
        }

        public override LexerToken ParseExpression3()
        {

            ParsingStruct exp3;


            exp3.currentTokenKind = tokens.Peek().Kind;
            exp3.currentToken = null;
            if (exp3.currentTokenKind == LexerTokenKind.Integer) //E3 -> num
                return tokens.Pop();
            // E3 -> ( E1 )
            if (exp3.currentTokenKind == LexerTokenKind.OpenParen)
            {
                tokens.Pop();
                exp3.currentToken = this.ParseExpression1();

                if (tokens.Peek().Kind == LexerTokenKind.CloseParen)
                    tokens.Pop();
                else
                    throw new ArgumentException("Invalid Expression");


            }



            return exp3.currentToken;

        }
    }
}
