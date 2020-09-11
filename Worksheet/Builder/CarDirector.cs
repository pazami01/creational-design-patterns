namespace QuestionTwo
{
    public class CarDirector : ICarDirector
    {
        private ICarBuilder _builder;

        public CarDirector(ICarBuilder cb)
        {
            _builder = cb;
        }

        public void Build()
        {
            _builder.BuildBodyStyle();
            _builder.BuildPower();
            _builder.BuildEngine();
            _builder.BuildBrakes();
            _builder.BuildSeats();
            _builder.BuildWindows();
            _builder.BuildFuelType();
        }
    }
}