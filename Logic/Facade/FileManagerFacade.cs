public class FileManagerFacade : IFileManagerFacade
{
    private IDataWriter writer;
    private IDataReader reader;

    public FileManagerFacade(IDataWriter writer, IDataReader reader){
        this.writer = writer;
        this.reader = reader;
    }

    public void WriteData(VehicleList list){
        writer.WriteData(list);
    } 

    public VehicleList ReadData(){
        return reader.ReadData();
    }

}