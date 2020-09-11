using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public Access Access { get; set; }
        public string ControlLevel { get; set; }

        public AccessControl(Access access, string controlLevel)
        {
            Access = access;
            ControlLevel = controlLevel;
        }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl Clone()
        {
            return new AccessControl(this.Access, this.ControlLevel);
        }
    }
}