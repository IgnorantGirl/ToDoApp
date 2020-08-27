using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
<<<<<<< HEAD

           ExpandColumn();
           
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) {
                string inputValue = inputText.Text;
                if (inputValue == "") return;
                var vm = this.DataContext as MainViewModel;
                vm.AddTaskInfo(inputValue);
                inputText.Text = string.Empty;
            }
        }

        private void ExpandColumn() {
            var cdf = grc.ColumnDefinitions;
            cdf[1].Width = new GridLength(280);

            btnmin.Foreground = new SolidColorBrush(Colors.Black);
            btnmax.Foreground = new SolidColorBrush(Colors.Black);
            btnclose.Foreground = new SolidColorBrush(Colors.Black);
=======
            Messenger.Default.Register<TaskInfo>(this, "Expand", ExpandColumn);
>>>>>>> 2a08905195145e969a8bb94a521503f6819c04cf

        }
        private void ControlIsLoaded(object sender, RoutedEventArgs e)
        {
           // MinButton button = (MinButton)VisualTreeHelper.GetChild(this.Template.FindName("minButton", this) as DependencyObject, 0);
            //button.Foreground = new SolidColorBrush(Colors.Black);
            // btnmax.Foreground = new SolidColorBrush(Colors.Black);
            btnmin.Foreground = new SolidColorBrush(Colors.Black);

<<<<<<< HEAD
        }
        /// <summary>
        /// Find Child with Visual Tree
        /// </summary>
        /// <typeparam name="T">specail type</typeparam>
        /// <param name="root">the element starts</param>
        /// <returns></returns>
        public static MinButton FindChild<Button>(DependencyObject root) where Button : DependencyObject
        {
            if (root == null)
                return null;

            MinButton founded = null;

            for (int j = 0; j < VisualTreeHelper.GetChildrenCount(root); j++)
            {
                DependencyObject d = VisualTreeHelper.GetChild(root, j);
                MinButton childType = d as MinButton;
                if (childType == null)
                {
                    founded = FindChild<Button>(d);
                    if (founded != null)
                        break;
                }
                else
                {
                    founded = childType;
                    break;
                }
            }

            return founded;
=======
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
>>>>>>> 2a08905195145e969a8bb94a521503f6819c04cf
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
