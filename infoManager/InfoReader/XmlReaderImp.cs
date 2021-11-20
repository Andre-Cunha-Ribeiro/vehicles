using System;
using System.IO;
using System.Xml.Serialization;
public class XmlReaderImp : IDataReader
{
    public VehicleList readData(){
        VehicleList? data = getInfoFromFile();
        if(data == null){
            throw new NullReferenceException();
        }
        return data;
    }

    private static VehicleList? getInfoFromFile()
        {
            using (TextReader reader = new StreamReader(@"Challenge_C#.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(VehicleList));
                return (VehicleList?)serializer.Deserialize(reader);
            }
        }
}