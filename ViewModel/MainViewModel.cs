using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
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
            menuModels.Add(new MenuModel() { IconFont = "\xe635", Title = "�ҵ�һ��", BackColor = "#218868"  ,Count = 5 , Display = false});
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Title = "��Ҫ", BackColor = "#f58f98", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Title = "�Ѽƻ��ճ�", BackColor = "#84bf96", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Title = "�ѷ������", BackColor = "#f8aba6", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Title = "����", BackColor = "#50b7c1", Count = 5 });
            //����Ĭ����
            MenuModel = MenuModels[0];

            //��ʼ������
            SelectedCommand = new RelayCommand<MenuModel>(t =>Select(t));

        }


        //����һ����̬���� MenuModel����
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

        #region command
        public RelayCommand<MenuModel> SelectedCommand { get; set; }

        private void Select(MenuModel model) {

            MenuModel = model;
        }

        #endregion

        #region method

        public void AddTaskInfo(string content) {
            MenuModel.TaskInfos.Add(new TaskInfo
            {
                Content = content
            });
        }

        #endregion
    }
}