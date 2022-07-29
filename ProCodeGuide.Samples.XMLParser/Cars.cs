using System.Xml.Serialization;

namespace FakeDataService.XMLParser
{
    public class Cars
    {
        [XmlElement("Car")]
        public List<Car> CarsList { get; set; }

    }
}
