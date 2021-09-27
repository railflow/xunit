using RailflowXunitLogger.Attributes;
using Xunit;

namespace RailflowXunitLogger.Tests
{
    [SmartAssignment("First Assignment")]
    public class FirstClassTest
    {
        [Fact]
        [JiraId("1234")]
        public void TestAdd()
        {
            Assert.Equal(5 + 5, 5 * 2);
        }

        [Fact]
        [JiraId("3456")]
        public void TestSubstract()
        {
            Assert.Equal(15 - 5, 5 * 2);
        }

        [Fact]
        [JiraId("7486")]
        public void TestDivide_FailingTest()
        {
            Assert.Equal(15 / 5, 5 * 2);
        }
    }
}
