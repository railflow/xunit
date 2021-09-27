using RailflowXunitLogger.Attributes;
using Xunit;

namespace RailflowXunitLogger.Tests2
{
    [SmartAssignment("Second Assignment")]
    public class SecondClassTest
    {
        [Fact]
        [JiraId("4354")]
        public void TestAdd()
        {
            Assert.Equal(5 + 5, 5 * 2);
        }

        [Fact]
        [JiraId("2290")]
        public void TestSubstract()
        {
            Assert.Equal(15 - 5, 5 * 2);
        }

        [Fact]
        [JiraId("4357")]
        public void TestDivide_FailingTest()
        {
            Assert.Equal(15 / 5, 5 * 2);
        }
    }
}
