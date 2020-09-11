using System;

namespace QuestionOne
{
    public static class ParserFactoryProducer
    {
        public static IAbstractParserFactory GetFactory(string placeFactory) => placeFactory switch
        {
            "NYCFactory" => new NYCParserFactory(),
            "SFFactory" => new SFParserFactory(),
            _ => null
        };
    }
}