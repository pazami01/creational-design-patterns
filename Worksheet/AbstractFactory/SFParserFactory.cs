using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionOne
{
    public class SFParserFactory : IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType) => parserType switch
        {
            "SFERROR" => new SFErrorXMLParser(),
            "SFFEEDBACK" => new SFFeedbackXMLParser(),
            "SFORDER" => new SFOrderXMLParser(),
            "SFRESPONSE" => new SFResponseXMLParser(),
            _ => null
        };
    }
}
