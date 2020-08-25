using GalaSoft.MvvmLight;
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
            menuModels.Add(new MenuModel() { IconFont = "\xe635", Title = "�ҵ�һ��", BackColor = "#218868"  });
            menuModels.Add(new MenuModel() { IconFont = "\xe6b6", Title = "��Ҫ", BackColor = "#EE3B3B"});
            menuModels.Add(new MenuModel() { IconFont = "\xe6e1", Title = "�Ѽƻ��ճ�", BackColor = "#218868", });
            menuModels.Add(new MenuModel() { IconFont = "\xe614", Title = "�ѷ������", BackColor = "#EE3B3B" });
            menuModels.Add(new MenuModel() { IconFont = "\xe755", Title = "����", BackColor = "#218868" });


        }


        //����һ����̬���� MenuModel����
        private ObservableCollection<MenuModel> menuModels;

        public ObservableCollection<MenuModel> MenuModels {

            get { return menuModels; }
            set { menuModels = value; RaisePropertyChanged(); }
        }

    }
}