

namespace DataClient
{
    public class DataFactory : IDataFiller
    {
        public DataContext Fill()
        {
            DataContext data = new DataContext();
            return data;
        }
    }
}
