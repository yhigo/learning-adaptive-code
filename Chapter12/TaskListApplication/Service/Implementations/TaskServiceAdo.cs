using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class TaskServiceAdo : ITaskService
    {
        public TaskServiceAdo(ISettings settings)
        {
            this.settings = settings;
        }

        public IEnumerable<TaskDto> GetAllTasks()
        {
            var allTasks = new List<TaskDto>();

            //using (var connection = new SqlConnection(settings.GetSetting("TaskDatabaseConnectionString")))
            //{
            //    connection.Open();

            //    using (var transaction = connection.BeginTransaction())
            //    {
            //        var command = connection.CreateCommand();
            //        command.Transaction = transaction;
            //        command.CommandType = CommandType.StoredProcedure;
            //        command.CommandText = "[dbo].[get_all_tasks]";

            //        using (var reader = command.ExecuteReader(CommandBehavior.CloseConnection))
            //        {
            //            if (reader.HasRows)
            //            {
            //                while (reader.Read())
            //                {
            //                    allTasks.Add(
            //                        new TaskDto
            //                        {
            //                            ID = reader.GetInt32(IDIndex),
            //                            Description = reader.GetString(DescriptionIndex),
            //                            Priority = reader.GetString(PriorityIndex),
            //                            DueDate = reader.GetDateTime(DueDateIndex),
            //                            Completed = reader.GetBoolean(CompletedIndex)
            //                        }
            //                    );
            //                }
            //            }
            //        }
            //    }
            //}

            // hack:実際にDB接続してタスクを作成するのは実装が大変なためコード上で作成して返却する
            allTasks.Add(new TaskDto() { ID = 1, Completed = false, Description = @"FromAdoService", DueDate = DateTime.Today, Priority = @"nomarl" });

            return allTasks;
        }


        private readonly ISettings settings;

        private const int IDIndex = 0;
        private const int DescriptionIndex = 1;
        private const int PriorityIndex = 2;
        private const int DueDateIndex = 3;
        private const int CompletedIndex = 4;
    }
}
