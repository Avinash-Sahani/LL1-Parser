using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Parser
{
    public static class EnumExtensionMethod
    {
        public static string GetDescription(this LexerTokenKind Kind)
        {
            var fieldInfo = Kind.GetType().GetField(Kind.ToString());

            var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : Kind.ToString();
        }
    }
}
