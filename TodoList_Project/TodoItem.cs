using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList_Project
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;


        public override string ToString()
        {
            // 三元運算子
            string status = IsCompleted ? "(v)" : "";
            string time = CreatedAt.ToString();

            return $"{status}{Id}.({time}) - {Title}";
        }

    }
}
