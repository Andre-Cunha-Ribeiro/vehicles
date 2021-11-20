using System.Text.Json;
public class DataManager
{
    private const string WRITER_PATH = @"Challenge_C#.json";
    private const string READER_PATH = @"Challenge_C#.xml";
    public DataManagerFacade dataManager {get;}

    public DataManager(){
        dataManager = new DataManagerFacade(new JsonWriterImp(WRITER_PATH), new XmlReaderImp(READER_PATH));
    }

    public void writeData(VehicleList list){
        dataManager.writeData(list);
    } 

    public VehicleList readData(){
        return dataManager.readData();
    }

}