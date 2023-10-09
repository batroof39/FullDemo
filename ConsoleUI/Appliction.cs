using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Appliction : IAppliction
    {
        IBussnisLogic _bussnisLogic;
        public Appliction(IBussnisLogic bussnisLogic)
        {
            _bussnisLogic = bussnisLogic;
        }
        public void Run()
        {
            _bussnisLogic.ProcessDate();
        }
    }
}
