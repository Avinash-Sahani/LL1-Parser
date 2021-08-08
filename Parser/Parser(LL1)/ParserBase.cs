using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.Parser_LL1_
{
    abstract class ParserBase
    {
       
        abstract public LexerToken ParseExpression1();
        abstract public LexerToken ParseExpression2();
        abstract public LexerToken ParseExpression3();

    }
}
