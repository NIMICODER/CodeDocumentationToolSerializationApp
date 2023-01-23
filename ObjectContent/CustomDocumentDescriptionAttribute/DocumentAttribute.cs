using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectContent.CustomDocumentDescriptionAttribute
{
    internal class DocumentAttribute
    {
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.All)]
        public class DescriptionAttribute : Attribute
        {
            [Description("This is Description property")]
            public string _Description { get; set; }

            [Description("This is the Input property")]
            public string _Input { get; set; } = "N/A";

            [Description("This is the Output property")]
            public string _Output { get; set; } = "N/A";
            public DescriptionAttribute(string description, string input = "N/A", string output = "N/A")
            {
                _Description = description;
                _Input = input;
                _Output = output;
            }
        }

        [AttributeUsage(AttributeTargets.Field)]
        public class EnumDescription : System.Attribute
        {
            private readonly string _description;

            public EnumDescription(string description)
            {
                _description = description;
            }

            public string Description
            {
                get { return _description; }
            }
        }
    }
}
