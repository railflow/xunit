namespace RailflowXunitLogger.Attributes
{
    public class JiraIdAttribute : MethodAttribute
    {
        public override string Value { get; }

        public JiraIdAttribute(string value)
        {
            Value = value;
        }
    }
}
