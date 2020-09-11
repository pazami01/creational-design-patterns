namespace QuestionOne
{
    public interface IAbstractParserFactory
    {
        public IXMLParser GetParserInstance(string parserType);
    }
}