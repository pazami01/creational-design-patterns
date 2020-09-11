using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    public class SFResponseXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing response XML...");
            return "SF response XML Message";
        }
    }
}
