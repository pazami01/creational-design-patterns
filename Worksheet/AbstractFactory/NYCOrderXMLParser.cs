using System;

namespace QuestionOne
{
    public class NYCOrderXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing order XML...");
            return "NY Order XML Message";
        }
    }
}