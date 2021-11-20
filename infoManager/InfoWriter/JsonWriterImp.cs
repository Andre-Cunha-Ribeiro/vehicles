using System.Text.Json;
public class JsonWriterImp : IDataWriter
{
    public void writeData(VehicleList list)
    {
        string fileName = @"Challenge_C#.json";
        string jsonString = JsonSerializer.Serialize(list, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, jsonString);
    }
}