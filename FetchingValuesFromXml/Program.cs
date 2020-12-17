using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchingValuesFromXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlFileOperations xmlFileOperations = new XmlFileOperations();
            var xmlContent = xmlFileOperations.GetXmlData("LegicAdvantMatrix");
            Console.WriteLine(xmlContent);

            ReadNodes readNodes = new ReadNodes();
            readNodes.GetNodesFromXml(,"GetReaderClassAnswer");


            Console.ReadLine();
        }
    }
}
