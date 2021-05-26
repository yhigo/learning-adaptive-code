using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListApplication.ViewModel
{
    public class TaskViewModel : ViewModelBase
    {
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Priority
        {
            get
            {
                return priority;
            }
            set
            {
                if (priority != value)
                {
                    priority = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                if (dueDate != value)
                {
                    dueDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool Completed
        {
            get
            {
                return completed;
            }
            set
            {
                if (completed != value)
                {
                    completed = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int id;
        private DateTime dueDate;
        private string description;
        private string priority;
        private bool completed;
    }
}
