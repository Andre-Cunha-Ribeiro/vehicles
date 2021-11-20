using System.Text.Json;
public class JsonWriterImp : IDataWriter
{
    private string filePath;
    public void writeData(VehicleList list)
    {
        string jsonString = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }

    public JsonWriterImp(string path){
        filePath = path;
    }
}