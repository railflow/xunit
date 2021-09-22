

using RailflowXunitLogger.Model;

namespace RailflowXunitLogger.Attributes
{
    public class SmartAssignmentAttribute : ClassAttribute
    {
        public override AttributeData AttributeData { get; }

        public SmartAssignmentAttribute(string value)
        {
            AttributeData = new ClassAttributeData("SmartAssignment", value);
        }
    }
}
