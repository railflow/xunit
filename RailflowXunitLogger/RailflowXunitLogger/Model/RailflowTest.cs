using RailflowXunitLogger.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RailflowXunitLogger.Model
{
    [DataContract]
    public class RailflowTest
    {
        [DataMember]
        public string FullName { get; set; }

        [DataMember]
        public string ClassFullName { get; set; }

        [DataMember]
        public string AssemblyFullName { get; set; }

        [DataMember]
        public List<ClassAttributeData> ClassAttributes { get; set; }

        [DataMember]
        public List<MethodAttributeData> MethodAttributes { get; set; }
    }
}