using RailflowXunitLogger.Attributes;
using Xunit;

namespace RailflowXunitLogger.Tests
{
    [SmartAssignment("Second Assignment")]
    public class SecondClassTest
    {
        [Fact]
        [JiraId("3243")]
        public void TestAdd()
        {
            Assert.Equal(5 + 5, 5 * 2);
        }

        [Fact]
        [JiraId("9804")]
        public void TestSubstract()
        {
            Assert.Equal(15 - 5, 5 * 2);
        }

        [Fact]
        [JiraId("1457")]
        public void TestDivide_FailingTest()
        {
            Assert.Equal(15 / 5, 5 * 2);
        }
    }
}
