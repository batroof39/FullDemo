using DemoLibrary.Utilties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BussnisLogic: IBussnisLogic
    {
        private readonly IDataAccess _dataAccess;
        private readonly ILogger _logger;
        public BussnisLogic(IDataAccess dataAccess,ILogger logger)
        {
            _dataAccess = dataAccess;
            _logger = logger;
        }
        public void ProcessDate()
        {
            _logger.LogMessage("starting to load data");
            Task.Delay(300);
            Console.WriteLine("Prossing data");
            _dataAccess.LoadData();
            _dataAccess.SaveDate();
            _logger.LogMessage("finshed prosseing data");
        }
    }
}
