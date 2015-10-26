using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysGreen.DeviceClass
{
    class MonitorControl:DeviceBase, DeviceInterface.ISupervise
    {
        public byte[] GetSuperviseGram()
        {
            byte[] gram = new byte[10];
            return gram;
        }
    }
}
