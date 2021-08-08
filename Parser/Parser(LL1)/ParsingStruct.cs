using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.Parser_LL1_
{
    struct ParsingStruct
    {
      public LexerToken currentToken;
        public LexerTokenKind currentTokenKind;
        public LexerToken ParentToken;
        public LexerToken leftchildToken;
        public LexerToken rightchildToken;
    }
}