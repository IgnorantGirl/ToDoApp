using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.ObjectModel;
using ToDoApp.Model;

namespace ToDoApp.ViewModel
{
    
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            MenuModels = new ObservableCollection<MenuModel>();
            menuModels.Add(new MenuModel() { IconFont = "\xe635", Title = "我的一天", BackColor = "#218868"  ,Count = 5 , Display = false});
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Title = "重要", BackColor = "#f58f98", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Title = "已计划日程", BackColor = "#84bf96", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Title = "已分配给我", BackColor = "#f8aba6", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Title = "任务", BackColor = "#50b7c1", Count = 5 });
            //设置默认项
            MenuModel = MenuModels[0];

            //初始化命令
            SelectedCommand = new RelayCommand<MenuModel>(t =>Select(t));
            SelectedTaskCommand = new RelayCommand<TaskInfo>(t => SelectTask(t));


        }




        //创建一个动态集合 MenuModel类型
        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModels {

            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }

        private MenuModel menuModel;

        public MenuModel MenuModel
        {
            get { return menuModel; }
            set { menuModel = value; RaisePropertyChanged(); }
        }

        private TaskInfo info;

        public TaskInfo Info
        {
            get { return info; }
            set { info = value; RaisePropertyChanged(); }
        }
        #region command
        public RelayCommand<MenuModel> SelectedCommand { get; set; }
        public RelayCommand<TaskInfo> SelectedTaskCommand { get; set; }


        #endregion

        #region method

        private void Select(MenuModel model)
        {

            MenuModel = model;
        }

        public void AddTaskInfo(string content)
        {
            MenuModel.TaskInfos.Add(new TaskInfo
            {
                Content = content
            });
        }

        public void SelectTask(TaskInfo task) {
            //通知前台页面--同样需要在页面注册一个方法
            Info = task;
            Messenger.Default.Send(task,"Expand");
        }
        #endregion

    }
}