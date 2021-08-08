using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Parser
{
    class LexerToken
    {

        public LexerToken(string Text,LexerTokenKind Kind)
        {
            this.Text = Text;
            this.Kind = Kind;
       
            childern = new List<LexerToken>();

        }
        public string Text { set; get; } = string.Empty;
        public LexerTokenKind Kind { set; get; }

        public int position = -1;

        public List<LexerToken> childern = null;

    }
}
