using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    public class SFErrorXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing Error XML...");
            return "SF Error XML Message";
        }
    }
}
