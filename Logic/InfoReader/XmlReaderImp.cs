using System;
using System.IO;
using System.Xml.Serialization;
public class XmlReaderImp : IDataReader
{
    private string _filePath;

    public VehicleList ReadData()
    {
        VehicleList? data = GetInfoFromFile();
        if (data == null)
        {
            throw new NullReferenceException();
        }
        return data;
    }

    private VehicleList? GetInfoFromFile()
    {
        using (TextReader reader = new StreamReader(_filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(VehicleList));
            return (VehicleList?)serializer.Deserialize(reader);
        }
    }

    public XmlReaderImp(String path)
    {
        this._filePath = path;
    }
}