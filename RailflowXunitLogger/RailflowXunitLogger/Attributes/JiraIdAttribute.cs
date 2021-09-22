using Microsoft.VisualStudio.TestTools.UnitTesting;
using RailflowXunitLogger.Model;
using System.Reflection;
using Xunit.Abstractions;

namespace RailflowXunitLogger.Attributes
{
    public class JiraIdAttribute : MethodAttribute
    {
        public override AttributeData AttributeData { get; }

        public JiraIdAttribute(string value)
        {
            AttributeData = new MethodAttributeData("JiraId", value);
        }
    }
}
