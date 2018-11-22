using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controller
{
    class ControllerBD
    {
        //fields
        private string connectionDB;
        private int nosirve = 0;

        //methods
        public ControllerBD()
        {
            connectionDB = string.Empty;
        }
    }
}
