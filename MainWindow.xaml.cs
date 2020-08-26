using GalaSoft.MvvmLight.Messaging;
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
using ToDoApp.Model;
using ToDoApp.ViewModel;

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
            this.DataContext = new MainViewModel();
            Messenger.Default.Register<TaskInfo>(this, "Expand", ExpandColumn);

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string inputValue = inputText.Text;
                if (inputValue == "") return;

                var vm = this.DataContext as MainViewModel;
                vm.AddTaskInfo(inputValue);
                inputText.Text = string.Empty;
            }
        }

        private void ExpandColumn(TaskInfo task) {
            var cdf = grc.ColumnDefinitions;
            if (cdf[1].Width == new GridLength(0))
            {
                cdf[1].Width = new GridLength(280);
            }
            else {
                cdf[1].Width = new GridLength(0);

            }
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
