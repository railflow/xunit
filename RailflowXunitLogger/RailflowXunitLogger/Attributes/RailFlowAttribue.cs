
using System.Reflection;
using Xunit.Sdk;

namespace RailflowXunitLogger.Attributes
{
    public abstract class RailFlowAttribue : BeforeAfterTestAttribute
    {
        public virtual string Value { get; }

        public override void Before(MethodInfo methodUnderTest)
        {
            // Todo: Capture the attribute value and add it to the attributes list
        }

        public override void After(MethodInfo methodUnderTest)
        {

        }
    }
}
