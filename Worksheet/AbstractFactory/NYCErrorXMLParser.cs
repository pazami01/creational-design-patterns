using System;

namespace QuestionOne
{
    public class NYCErrorXMLParser : IXMLParser
    {
        public string Parse()
        {
            Console.WriteLine("NY Parsing error XML...");
            return "NY Error XML Message";
        }
    }
}