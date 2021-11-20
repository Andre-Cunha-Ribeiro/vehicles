using System.Xml;
using System.Xml.Serialization;

public class Vehicle
{
    [XmlIgnore]
    public string Id { get; }

    [XmlAttribute]
    public string? type { get; set; }

    [XmlElement(ElementName = "color")]
    public string? color { get; set; }

    [XmlElement(ElementName = "motor")]
    public Motor? motor { get; set; }

    [XmlArray("wheels")]
    [XmlArrayItem("wheel")] 
    public Wheel[] Wheels { get; set; }

    public Vehicle(){
        Id = Guid.NewGuid().ToString(); 
    }
}

[XmlRoot("vehicles")]
public class VehicleList
{
    [XmlElement(ElementName = "vehicle")]
    public List<Vehicle> Vehicles { get; set; }

    public VehicleList(){
        Vehicles = new List<Vehicle>();
    }
}