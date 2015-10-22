using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SysGreen.DeviceBase
{
    /// <summary>
    /// MotionSensor.xaml 的交互逻辑
    /// </summary>
    public partial class MotionSensor : UserControl, DeviceInterface.ISupervise
    {
        public MotionSensor()
        {
            InitializeComponent();
            //LayoutRoot.MouseMove+=new MouseEventHandler(LayoutRoot_MouseMove);
        }

        public MouseEventHandler LayoutRoot_MouseMove { get; set; }
        public byte[] GetSuperviseGram()
        {
            byte[] result = new byte[10];
            return result;
        }
    }
}
