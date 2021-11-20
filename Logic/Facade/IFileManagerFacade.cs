public interface IFileManagerFacade
{
    void WriteData(VehicleList list);

    VehicleList ReadData();
}