using System.Runtime.Serialization;

namespace RailflowXunitLogger.Model
{
    [DataContract]
    public class AttributeData
    {
        public AttributeData(string name, string value)
        {
            Name = name;
            Value = value;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }
    }
}