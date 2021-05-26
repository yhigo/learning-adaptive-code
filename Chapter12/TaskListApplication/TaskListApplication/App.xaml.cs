using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using AutoMapper;
using Service.Implementations;
using Service;
using TaskListApplication.ViewModel;

namespace TaskListApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            CreateMappings();

            container = new UnityContainer();
            container.RegisterType<ISettings, ApplicationSettings>();
            container.RegisterType<Service.Interfaces.IObjectMapper, MapperAutoMapper>();
            container.RegisterType<ITaskService, TaskServiceAdo>();
            container.RegisterType<TaskListController>();
            container.RegisterType<TaskListView>();

            MainWindow = container.Resolve<TaskListView>();
            MainWindow.Show();

            ((TaskListController)MainWindow.DataContext).OnLoad();
        }

        private void CreateMappings()
        {
            // AutoMapper.Mapper.CreateMap<TaskDto, TaskViewModel>();
        }

        private IUnityContainer container;
    }
}
