using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    class Lexer : LexerBase
    {
        public string SourceText { set; get; } = string.Empty;
        public LexerToken Token;

        public Lexer(string SourceText)
        {
            this.SourceText = SourceText;
        }


        public override IEnumerable<LexerToken> Tokens
        {
         
            get
            {

                for (int index=0; index<SourceText.Length; index++)
                {
                    Token = null;
                    string subvalue = SourceText[index].ToString();
                    LexerTokenKind kind = GetTokenKind(subvalue);
                    if (kind != LexerTokenKind.Invaild)
                    {
                        Token = new LexerToken(subvalue, kind);

                      
                    }
                   else if (int.TryParse(subvalue, out int n))
                    {
                        Token = new LexerToken(subvalue, LexerTokenKind.Integer);
                    }
                   
                    if(Token!=null || Token.Kind == LexerTokenKind.WhiteSpace)
                    {
                       
                        yield return Token;
                    }
                    
                    else
                    throw new ArgumentException("Invalid Token: ",subvalue);

                }

              
            }
          
        }

        public LexerTokenKind GetTokenKind(string text)
        {
            LexerTokenKind kind=LexerTokenKind.Invaild;


            foreach (LexerTokenKind k in Enum.GetValues(typeof(LexerTokenKind)))
            {
                
                if(text.Equals(k.GetDescription()))
                {
                    kind = k;
                }

            }
            return kind;


         
        }

    }
}