using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.AvalonDock;
using Xceed.Wpf.AvalonDock.Themes;

namespace GraphicDeviceKit
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AttachEvent();
        }

        private void themeVS_Click(object sender, RoutedEventArgs e)
        {
            this.DockManager.Theme = new VS2010Theme();
        }

        private void themeMetro_Click(object sender, RoutedEventArgs e)
        {
            this.DockManager.Theme = new MetroTheme();
        }

        private void themeLight_Click(object sender, RoutedEventArgs e)
        {
            this.DockManager.Theme = new ExpressionLightTheme();
        }

        private void themeDark_Click(object sender, RoutedEventArgs e)
        {
            this.DockManager.Theme = new ExpressionDarkTheme();
        }

        private void themeAero_Click(object sender, RoutedEventArgs e)
        {
            this.DockManager.Theme = new AeroTheme();
        }

        private void themeGeneric_Click(object sender, RoutedEventArgs e)
        {
            this.DockManager.Theme = new GenericTheme();
        }

        private void miSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fileSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fileLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void programExit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AttachEvent()
        {
            mToolBox.PreviewMouseMove += OnPreviewToolBoxMouseMove;
            mToolBox.QueryContinueDrag += OnQueryContinueDrag;
        }
        private void OnPreviewToolBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton != MouseButtonState.Pressed)
                return;
            Point position = e.GetPosition(mToolBox);
            HitTestResult result = VisualTreeHelper.HitTest(mToolBox, position);
            if (result == null)
                return;
            ListBoxItem tool = Utils.FindVisualParent<ListBoxItem>(result.VisualHit);
            if (tool == null)// || tool.Content != mToolBox.SelectedItem)// || !(mToolBox.SelectedItem is ToolBoxItem))
                return;
            //ToolBoxItem tbi = tool.Content as ToolBoxItem;
            ToolBoxItem tbi = new ToolBoxItem(tool.Content.ToString());
            DataObject dataObject = new DataObject(tbi.Clone());
            System.Windows.DragDrop.DoDragDrop(mToolBox, dataObject, DragDropEffects.Copy);
            mEditSize.Content = mEidtor.Height.ToString() + "," + mEidtor.Width.ToString();
        }
        private void OnQueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            Point position = e.GetPosition(mEidtor);

            //ToolBoxItem toolItem = e.Data.GetData(typeof(ToolBoxItem)) as ToolBoxItem;
            ListBoxItem select = mToolBox.SelectedItem as ListBoxItem;
            if (select != null)
            {
                if (select.Name == "TemperaPanel")
                {
                    SysGreen.DeviceBase.ControlPanel cp = new SysGreen.DeviceBase.ControlPanel();
                    mEidtor.Children.Add(cp);
                    cp.SetValue(Canvas.TopProperty, position.Y);
                    cp.SetValue(Canvas.LeftProperty, position.X);

                }
                else if (select.Name == "MonitorControl")
                {
                    SysGreen.DeviceBase.TemperaMonitor tmpMonitor = new SysGreen.DeviceBase.TemperaMonitor();
                    mEidtor.Children.Add(tmpMonitor);
                    tmpMonitor.SetValue(Canvas.TopProperty, position.Y);
                    tmpMonitor.SetValue(Canvas.LeftProperty, position.X);
                }
                else if (select.Name == "MotionSensor")
                {
                    SysGreen.DeviceBase.MotionSensor ms = new SysGreen.DeviceBase.MotionSensor();
                    mEidtor.Children.Add(ms);
                    ms.SetValue(Canvas.TopProperty, position.Y);
                    ms.SetValue(Canvas.LeftProperty, position.X);

                }
                else if (select.Name == "WindowMagnet")
                {
                }
            }

        }

        private void OnDragOver(object sender, DragEventArgs e)
        {

            mEidtor.Focus();
        }
        
    }

    internal static class Utils
    {
        public static T FindVisualParent<T>(DependencyObject obj) where T : class
        {
            while (obj != null)
            {
                if (obj is T)
                    return obj as T;

                obj = VisualTreeHelper.GetParent(obj);
            }

            return null;
        }
    }
}
