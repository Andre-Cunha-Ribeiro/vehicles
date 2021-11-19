using System.Xml;
using System.Xml.Serialization;
public class Car : Vehicle
{
        public Motor? motor {get; set;}

        [XmlElement(ElementName = "wheels")]
         List<Wheel> wheels = new List<Wheel>(4);
}