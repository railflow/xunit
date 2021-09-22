using Newtonsoft.Json.Linq;
using RailflowXunitLogger.Attributes;
using RailflowXunitLogger.Persistence;
using System;
using Xunit;

namespace RailflowXunitLogger.Tests
{
    [SmartAssignment("Ok Smart")]
    public class UnitTestOne : IDisposable
    {
        public void Dispose()
        {
            var store = InMemoryStore.Instance;
            var testsReport = store.GetRailflowTests();
            var jsonReport = JObject.FromObject(testsReport);
            var jsonReportContent = jsonReport.ToString();
            Console.WriteLine(jsonReportContent);
        }

        [Fact]
        [JiraId("555")]
        public void Test1()
        {
            Assert.True(5 == 5);
        }

        [Fact]
        [JiraId("666")]
        public void Test2()
        {
            Assert.True(5 == 5);
        }

        [Fact]
        [JiraId("777")]
        public void Test3()
        {
            Assert.True(5 == 5);
        }


    }
}
