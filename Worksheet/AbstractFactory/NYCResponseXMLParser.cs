using System;

namespace QuestionOne
{
    public class NYCResponseXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing response XML...");
            return "NY response XML Message";
        }
    }
}