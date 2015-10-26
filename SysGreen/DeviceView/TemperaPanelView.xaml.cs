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
    /// ControlPanel.xaml 的交互逻辑
    /// </summary>
    public partial class ControlPanel : UserControl
    {
        string deviceAddress;
        public ControlPanel()
        {
            InitializeComponent();
        }

        public void SetViewInfo(string _info)
        {
        }
    }
}
