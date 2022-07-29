using System.Xml.Linq;
using System.Xml.Serialization;

namespace FakeDataService.XMLParser
{
    internal class XMLUtility
    {
        

        internal static void ReadXMLFileUsingLINQ()
        {
            Console.WriteLine("Output using LINQ");
            foreach (XElement xElement in XElement.Load(@"Cars.xml").Elements("Car"))
            {
                Console.WriteLine("Make of the Car is : " + xElement.Element("Make").Value);
                //Console.WriteLine("Seats of the Car is : " + xElement.Element("Seats").Value);
                Console.WriteLine();
            }
        }

        internal static void ReadNestedXMLFile(string xmlfile)
        {
            //string make = "BMW";
            //loop through each node and save it value in NodeStr
            //var NodeStr = "";
            Cars cars = (Cars)DeSerializeXMl(typeof(Cars), xmlfile);

            foreach (var item in cars.CarsList)
            {
                Console.WriteLine("Make = {0}", item.Make);
                foreach (var seat in item.Seats)
                {
                    Console.WriteLine("Seat option: " + seat);
                }
                foreach (var ft in item.FuelTypes)
                {
                    Console.WriteLine("FuelType option: " + ft);
                }
            }

            //Car car = cars.CarsList.Find(x => x.Make == make);
            //cars.CarsList.ForEach((v) => Console.WriteLine("Element = {0}", v.Make));
            //print
            
        }
        private static object DeSerializeXMl(Type type, string fileName)
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                var deseralizer = new XmlSerializer(type);
                object obj = deseralizer.Deserialize(reader);
                return obj;
            }
        }

        public static string GetFilePath(string fileName)
        {
            //string serviceType = "offline";
            // Get the current directory.
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("GetCurrentDirectory " + path);           
            string xmlFilePath = Path.Combine(path, fileName);
            Console.WriteLine("xmlFile " + xmlFilePath);

            //path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\" + fileName;
            //Console.WriteLine("GetDirectoryName " + path);
            //string xmlFilePath = new Uri(path).LocalPath;
            ////print
            //Console.WriteLine("LocalPath " + xmlFilePath);

            return xmlFilePath;
        }


    }
}
