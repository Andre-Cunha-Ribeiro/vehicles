using System.Xml;
using System.Xml.Serialization;

public class Truck : Vehicle
{
    public Motor? Motor { get; set; }

    [XmlElement(ElementName = "wheels")]
    List<Wheel> Wheels = new List<Wheel>(8);
}