using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utilties
{
    public interface IDataAccess
    {
         void LoadData();
         void SaveDate();
    }
}
