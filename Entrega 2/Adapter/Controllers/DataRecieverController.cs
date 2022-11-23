using AdapterPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Linq;
using AdapterPattern.Adapters;

namespace AdapterPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class json2xmlController : ControllerBase
    {
        //Función que recibe peticiones POST en JSON y las regresa en XML:
        [HttpPost(Name= "json2xml")]
        public string json2xml(GameModel gameData)
        {
            string gameDataJson = Newtonsoft.Json.JsonConvert.SerializeObject(gameData);

            XmlAdapter adaptador = new XmlAdapter();

            string xmlAdaptedData = adaptador.JsonToXmlAdapter(gameDataJson);

            return xmlAdaptedData.ToString();
        }
    }
}
