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
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Title = "��Ҫ", BackColor = "#EE3B3B", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Title = "�Ѽƻ��ճ�", BackColor = "#218868", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Title = "�ѷ������", BackColor = "#EE3B3B", Count = 5 });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Title = "����", BackColor = "#218868", Count = 5 });

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
    }
}