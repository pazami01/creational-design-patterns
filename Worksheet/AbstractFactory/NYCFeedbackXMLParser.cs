using System;

namespace QuestionOne
{
    public class NYCFeedbackXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing feedback XML...");
            return "NY feedback XML Message";
        }
    }
}