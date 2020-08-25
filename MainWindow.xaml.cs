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

namespace ToDoApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




    }
    #region SystemButton
    public class MinButton : Button
    {
        protected override void OnClick()
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }
    }
    public class MaxButton : Button
    {
        protected override void OnClick()
        {
            Window.GetWindow(this).WindowState = WindowState.Maximized;
        }
    }
    public class RestoreButton : Button
    {
        protected override void OnClick()
        {
            Window.GetWindow(this).WindowState = WindowState.Normal;
        }
    }
    public class CloseButton : Button
    {
        protected override void OnClick()
        {
            Window.GetWindow(this).Close();
        }
    }
    #endregion
}
