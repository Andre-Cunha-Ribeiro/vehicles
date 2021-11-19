using System.Xml;
using System.Xml.Serialization;

public class Wheel
{
    [XmlAttribute(AttributeName = "size")]
    public int Size { get; set; }

    [XmlAttribute(AttributeName = "pressure")]
    public int Pressure { get; set; }
}


