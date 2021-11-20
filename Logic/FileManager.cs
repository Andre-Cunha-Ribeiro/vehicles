using System.Text.Json;
public class FileManager
{
    private const string WriterPath = @"Challenge_C#.json";
    private const string ReaderPath = @"Challenge_C#.xml";
    private FileManagerFacade _dataManager;

    public FileManager(){
        _dataManager = new FileManagerFacade(new JsonWriterImp(WriterPath), new XmlReaderImp(ReaderPath));
    }

    public void WriteData(VehicleList list){
        _dataManager.WriteData(list);
    } 

    public VehicleList ReadData(){
        return _dataManager.ReadData();
    }

}