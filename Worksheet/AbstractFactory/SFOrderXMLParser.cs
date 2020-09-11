using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    public class SFOrderXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing order XML...");
            return "SF Order XML Message";
        }
    }
}
