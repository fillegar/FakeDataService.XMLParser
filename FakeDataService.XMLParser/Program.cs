// See https://aka.ms/new-console-template for more information
using FakeDataService.XMLParser;


string xmlfile = XMLUtility.GetFilePath("cars.xml");
//XMLUtility.ReadXMLFileUsingLINQ();
XMLUtility.ReadNestedXMLFile(xmlfile);

Console.ReadLine();
