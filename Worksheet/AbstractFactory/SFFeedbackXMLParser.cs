using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    public class SFFeedbackXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("SF Parsing feedback XML...");
            return "SF Feedback XML Message";
        }
    }
}
