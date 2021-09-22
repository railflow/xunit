
using RailflowXunitLogger.Model;
using RailflowXunitLogger.Persistence;
using System;
using System.Reflection;
using System.Runtime.Serialization;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace RailflowXunitLogger.Attributes
{
    [DataContract]
    public abstract class RailFlowAttribute : BeforeAfterTestAttribute
    {
        [DataMember]
        public virtual AttributeData AttributeData { get; }

        public override void Before(MethodInfo methodUnderTest)
        {
            var storeInstance = InMemoryStore.Instance;
            storeInstance.AddUnitTest(
                methodUnderTest.Name,
                methodUnderTest.DeclaringType.FullName,
                methodUnderTest.DeclaringType.AssemblyQualifiedName,
                AttributeData);
        }

        public override void After(MethodInfo methodUnderTest)
        {
            // Do nothing
        }
    }
}
