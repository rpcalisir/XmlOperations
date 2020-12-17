using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FetchingValuesFromXml
{
    public class ReadNodes
    {
        /// <summary>
        /// Gets node with specified name from xml.
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public IEnumerable<object> GetNodesFromXml(object parentNode, string nodeName)
        {
            XElement xmlParentNode = parentNode as XElement;
            IEnumerable<XElement> expectedNodesUnderParentNode = null;

            if (xmlParentNode != null)
            {
                expectedNodesUnderParentNode = xmlParentNode.DescendantsAndSelf().Where(p => p.Name.LocalName == nodeName);
            }
            else
            {
                throw new Exception("Could not found node " + nodeName + " because parent node is null");
            }
            if (expectedNodesUnderParentNode == null)
            {
                throw new Exception("Could not found node " + nodeName + " under parent node");
            }
            return expectedNodesUnderParentNode;
        }
    }
}
