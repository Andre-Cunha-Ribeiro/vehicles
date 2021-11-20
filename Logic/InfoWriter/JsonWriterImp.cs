using System.Text.Json;
public class JsonWriterImp : IDataWriter
{
    private string _filePath;
    public void WriteData(VehicleList list)
    {
        string jsonString = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, jsonString);
    }

    public JsonWriterImp(string path){
        _filePath = path;
    }
}