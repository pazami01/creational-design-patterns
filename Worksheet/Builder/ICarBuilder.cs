namespace QuestionTwo
{
    public interface ICarBuilder
    {
        ICar GetCar();

        public void BuildBodyStyle();
        public void BuildPower();
        public void BuildEngine();
        public void BuildBrakes();
        public void BuildSeats();
        public void BuildWindows();
        public void BuildFuelType();
    }
}