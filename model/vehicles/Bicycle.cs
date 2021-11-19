using System.Xml;
using System.Xml.Serialization;
public class Bicycle : Vehicle
{
    [XmlElement(ElementName = "wheels")]
         List<Wheel> wheels = new List<Wheel>(2);



}