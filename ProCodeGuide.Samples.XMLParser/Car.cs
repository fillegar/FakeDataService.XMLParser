using System.Runtime.Serialization;

namespace FakeDataService.XMLParser
{
    [DataContract(Namespace = "http://tempuri.org/")]
    public class Car
    {
        [DataMember]
        public string Make { get; set; }

        [DataMember]
        public List<int> Seats { get; set; }

        [DataMember]
        public List<string> FuelTypes { get; set; }


    }
}
