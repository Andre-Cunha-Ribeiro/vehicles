public interface IDataManagerFacade
{
    void writeData(VehicleList list);

    VehicleList readData();
}