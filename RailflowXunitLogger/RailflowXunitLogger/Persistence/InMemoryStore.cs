using RailflowXunitLogger.Model;
using System.Collections.Generic;
using System.Linq;

namespace RailflowXunitLogger.Persistence
{
    public class InMemoryStore
    {
        private static readonly RailflowTests railflowTests = new RailflowTests { UnitTests = new List<RailflowTest>() };
        private static readonly object obj = new object();
        private static InMemoryStore instance = null;

        private InMemoryStore()
        {
        }

        public static InMemoryStore Instance
        {
            get
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new InMemoryStore();
                    }
                    return instance;
                }

            }
        }

        public void AddUnitTest(
            string testName,
            string className,
            string assemblyName,
            AttributeData attribute)
        {
            bool testExists = railflowTests.UnitTests.Where(test => test.FullName.Equals(testName)).Any();
            if (testExists)
            {
                if (attribute is MethodAttributeData methodAttributeData)
                {
                    railflowTests.UnitTests.Where(test => test.FullName.Equals(testName))
                        .First()
                        .MethodAttributes
                        .Add(methodAttributeData);
                }
                else if (attribute is ClassAttributeData classAttributeData)
                {
                    railflowTests.UnitTests.Where(test => test.FullName.Equals(testName))
                        .First()
                        .ClassAttributes
                        .Add(classAttributeData);
                }

            }
            else
            {
                var methodAttributes = new List<MethodAttributeData>();
                var classAttributes = new List<ClassAttributeData>();
                if (attribute is MethodAttributeData methodAttributeData)
                {
                    methodAttributes.Add(methodAttributeData);
                }
                else if (attribute is ClassAttributeData classAttributeData)
                {
                    classAttributes.Add(classAttributeData);
                }
                var unitTest = new RailflowTest
                {
                    FullName = testName,
                    ClassFullName = className,
                    AssemblyFullName = assemblyName,
                    MethodAttributes = methodAttributes,
                    ClassAttributes = classAttributes
                };
                railflowTests.UnitTests.Add(unitTest);
            }
        }

        public RailflowTests GetRailflowTests()
        {
            return railflowTests;
        }
    }
}
