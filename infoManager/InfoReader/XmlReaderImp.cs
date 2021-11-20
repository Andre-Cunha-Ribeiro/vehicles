using System;
using System.IO;
using System.Xml.Serialization;
public class XmlReaderImp : IDataReader
{
    private string filePath;

    public VehicleList readData()
    {
        VehicleList? data = getInfoFromFile();
        if (data == null)
        {
            throw new NullReferenceException();
        }
        return data;
    }

    private VehicleList? getInfoFromFile()
    {
        using (TextReader reader = new StreamReader(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VehicleList));
            return (VehicleList?)serializer.Deserialize(reader);
        }
    }

    public XmlReaderImp(String path){
        this.filePath = path;
    }
}