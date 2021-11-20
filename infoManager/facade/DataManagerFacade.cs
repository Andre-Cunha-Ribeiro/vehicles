public class DataManagerFacade : IDataManagerFacade
{
    public IDataWriter writer;
    public IDataReader reader;

    public DataManagerFacade(IDataWriter writer, IDataReader reader){
        this.writer = writer;
        this.reader = reader;
    }

    public void writeData(VehicleList list){
        writer.writeData(list);
    } 

    public VehicleList readData(){
        return reader.readData();
    }

}