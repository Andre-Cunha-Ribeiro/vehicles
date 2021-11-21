using System.Xml;
using System.Xml.Serialization;
public class Engine
{
    [XmlAttribute(AttributeName = "type")]
    public string? Type { get; set; }

    [XmlElement(ElementName = "power")]
    public PowerAmount? Power { get; set; }

    [XmlElement(ElementName = "displacement")]
    public DisplacementAmount? Displacement { get; set; }
}

public class PowerAmount
{
    [XmlText]
    public int Value { get; set; }
}

public class DisplacementAmount
{
    [XmlText]
    public int Value { get; set; }
}