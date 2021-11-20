using System.Xml;
using System.Xml.Serialization;

public class Vehicle
{
    [XmlIgnore]
    public string Id { get; }

    [XmlAttribute(AttributeName = "type")]
    public string? Type { get; set; }

    [XmlElement(ElementName = "color")]
    public string? Color { get; set; }

    [XmlElement(ElementName = "motor")]
    public Motor? Motor { get; set; }

    [XmlArray("wheels")]
    [XmlArrayItem("wheel")]
    public Wheel[]? Wheels { get; set; }

    public Vehicle()
    {
        Id = Guid.NewGuid().ToString();
    }
}

[XmlRoot("vehicles")]
public class VehicleList
{
    [XmlElement(ElementName = "vehicle")]
    public List<Vehicle> Vehicles { get; set; }

    public VehicleList()
    {
        Vehicles = new List<Vehicle>();
    }
}