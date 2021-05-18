using System;
using System.Collections.Generic;
using System.Text;

namespace DataClient
{
    public interface IDataFiller
    {
        DataContext Fill();
    }
}
