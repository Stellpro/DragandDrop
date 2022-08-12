using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragandDrop.Data
{
    public class TaskModel
    {
        public int Id { get; set; }
        public TaskStatuses Status { get; set; }
        public string Detail { get; set; }
        public  DateTime UpDatedTime { get; set; }
    }

    public enum TaskStatuses
    {
        Todo,
        Started,
        Completed
    }
}
