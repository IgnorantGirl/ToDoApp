﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Model
{
    public class MenuModel:ViewModelBase
    {
        public string IconFont { get; set; }

        public string Title { get; set; }

        public string BackColor { get; set; }

        public int Count { get; set; }

        public bool Display { get; set; } = true;

<<<<<<< HEAD
=======
        //动态集合存储TaskInfo
>>>>>>> 2a08905195145e969a8bb94a521503f6819c04cf
        private ObservableCollection<TaskInfo> taskInfos = new ObservableCollection<TaskInfo>();

        public ObservableCollection<TaskInfo> TaskInfos
        {
            get { return taskInfos; }
<<<<<<< HEAD
            set { taskInfos = value;
                RaisePropertyChanged();
             }

        }

       
    }

    public class TaskInfo
    {

        public string Content { get; set; }
=======
            set { taskInfos = value; RaisePropertyChanged(); }
        }
    }
    public class TaskInfo
    {
        public string Content { get; set; }

>>>>>>> 2a08905195145e969a8bb94a521503f6819c04cf
    }
}
