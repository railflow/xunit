using Newtonsoft.Json.Linq;
using RailflowXunitLogger.Persistence;
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace RailflowXunitLogger
{
    public class LoggerMessageSink : IMessageSink
    {
        public bool OnMessage(IMessageSinkMessage message)
        {
            // Do what you want to in response to events here.
            // 
            // Each event has a corresponding implementation of IMessageSinkMessage.
            // See examples here: https://github.com/xunit/abstractions.xunit/tree/master/src/xunit.abstractions/Messages
            if (message is ITestAssemblyExecutionFinished)
            {
                var store = InMemoryStore.Instance;
                var testsReport = store.GetRailflowTests();
                var jsonReport = JObject.FromObject(testsReport);
                var jsonReportContent = jsonReport.ToString();
                File.WriteAllText(
                    Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "../../..", "AttributesLog.json"),
                    jsonReportContent);
            }

            // Return `false` if you want to interrupt test execution.
            return true;
        }
    }
}
