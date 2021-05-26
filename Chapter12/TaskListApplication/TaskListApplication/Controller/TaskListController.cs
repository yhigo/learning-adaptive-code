using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskListApplication.ViewModel;

namespace TaskListApplication
{
    public class TaskListController : ViewModelBase
    {
        public TaskListController(ITaskService taskService, IObjectMapper mapper)
        {
            this.taskService = taskService;
            this.mapper = mapper;
        }

        public void OnLoad()
        {
            var taskDtos = taskService.GetAllTasks();
            AllTasks = new ObservableCollection<TaskViewModel>(mapper.Map<IEnumerable<TaskViewModel>>(taskDtos));
        }

        public ObservableCollection<TaskViewModel> AllTasks
        {
            get
            {
                return allTasks;
            }
            set
            {
                allTasks = value;
                RaisePropertyChanged();
                // 明示的にどのプロパティを更新するか指定する時は下記のように記述する
                // RaisePropertyChanged(nameof(AllTasks));
            }
        }

        private readonly ITaskService taskService;
        private readonly IObjectMapper mapper;
        private ObservableCollection<TaskViewModel> allTasks;
    }
}
