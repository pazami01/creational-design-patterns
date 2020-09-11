using System;

namespace QuestionFour
{
    public interface IPrototype : ICloneable
    {
        public new AccessControl Clone();
    }
}