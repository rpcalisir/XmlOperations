using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FetchingValuesFromXml
{
    public class XmlFileOperations
    {
        /// <summary>
        /// Reads xml file content
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public XDocument GetXmlData(string fileName)
        {
            XDocument xmlMediaDefinition;
            string mediaDefinition = File.ReadAllText(GetFilePath(fileName));
            if (!String.IsNullOrEmpty(mediaDefinition))
            {
                xmlMediaDefinition = XDocument.Parse(mediaDefinition);
            }
            else
            {
                throw new Exception("Media definition file " + fileName + " is empty.");
            }
            return xmlMediaDefinition;
        }

        private string GetFilePath(string fileName)
        {
            string path = ConfigurationManager.AppSettings[fileName];
            if (File.Exists(path))
            {
                return path;
            }
            else
            {
                throw new Exception("There is no file in given path:" + path);
            }
        }
    }
}
