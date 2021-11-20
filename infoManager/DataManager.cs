using System.Text.Json;
public class DataManager
{
    public IDataWriter writer;

    public IDataReader reader;

    public DataManager(){
        this.writer = new JsonWriterImp();
        this.reader = new XmlReaderImp();
    }

    public void writeData(VehicleList list){
        writer.writeData(list);
    } 

    public VehicleList readData(){
        return reader.readData();
    }

}