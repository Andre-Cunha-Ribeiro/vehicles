using System.Xml;
using System.Xml.Serialization;

public class Vehicle 
{
    public int Id {get;}

}

[XmlRoot("vehicles")]
public class VehiclesList 
{
    [XmlElement("vehicle")]
    public List<Vehicle>? Vehicles 
    { get; set; }
}