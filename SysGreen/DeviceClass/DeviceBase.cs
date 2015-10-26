using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysGreen.DeviceClass
{
    enum ControlMode
    {
        SAVE_ENERGY = 2,
        LOCAL_CONTROL = 1,
        COLLECT_CONTROL = 0
    }
    abstract class DeviceBase
    {
        protected bool isOpen;
        protected ControlMode controlMode;
    }
}
