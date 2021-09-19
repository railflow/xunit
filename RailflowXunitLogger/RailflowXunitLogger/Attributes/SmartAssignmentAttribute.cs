

namespace RailflowXunitLogger.Attributes
{
    public class SmartAssignmentAttribute : ClassAttribute
    {
        public override string Value { get; }

        public SmartAssignmentAttribute(string value)
        {
            Value = value;
        }
    }
}
