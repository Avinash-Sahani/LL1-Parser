using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Parser
{



    public enum LexerTokenKind
    {

       [Description("+")]
        Plus,
       [Description("-")]
        Minus,
       [Description("*")]
        Asterisk,
       [Description("/")]
        Divide,
       [Description("(")]
        OpenParen,
       [Description(")")]
        CloseParen,
       [Description("$")]
       END,
       [Description(" ")]
       WhiteSpace,
        Integer, 
       Invaild







    }


}
