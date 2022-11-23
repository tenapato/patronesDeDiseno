using Newtonsoft.Json;
using System.Xml.Linq;

namespace AdapterPattern.Adapters
{
    public class XmlAdapter
    {
        public string JsonToXmlAdapter(string jsonToAdapt)
        {
            XNode adaptedNode = JsonConvert.DeserializeXNode(jsonToAdapt, "Game");
            return adaptedNode.ToString();
        }
    }
}
