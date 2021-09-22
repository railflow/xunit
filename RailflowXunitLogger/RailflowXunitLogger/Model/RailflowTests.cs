using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RailflowXunitLogger.Model
{
    [DataContract]
    public class RailflowTests
    {
        [DataMember]
        public List<RailflowTest> UnitTests { get; set; }
    }
}
