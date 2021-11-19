using System.Xml;
using System.Xml.Serialization;
public class Motor
{
    [XmlAttribute(AttributeName = "type")]
    public string? Type { get; set; }

    [XmlElement(ElementName = "power")]
    public Power? Power { get; set; }
}

public class Power
{
    [XmlText]
    public int Value { get; set; }
}