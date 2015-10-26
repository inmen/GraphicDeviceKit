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
    /// TemperaMonitor.xaml 的交互逻辑
    /// </summary>
    public partial class TemperaMonitor : UserControl
    {
        public EventHandler<DeviceEvent.MonitorUpdateEvent> updateInfo;
        private string address;
        public readonly string description;
        public TemperaMonitor()
        {
            InitializeComponent();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("监控器 ");
            sb.Append(address);
            sb.Append(description);
            return sb.ToString();
        }
    }
}
