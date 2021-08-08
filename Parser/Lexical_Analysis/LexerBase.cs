using System;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    abstract class LexerBase
    {
        abstract public IEnumerable<LexerToken> Tokens { get; }

    }

}