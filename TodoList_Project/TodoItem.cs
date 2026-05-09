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

        public string Save()
        {
            // 三元運算子
            string status = IsCompleted ? "(v)" : "";
            string time = CreatedAt.ToString();

            return $"{status},{Id},{time},{Title}";
        }


        public TodoItem Load(string str)
        {
            // (v),2,2026/5/9 下午 03:20:13,測試2
            string[] strings = str.Split(",");

            TodoItem item = new TodoItem();

            item.IsCompleted = strings[0] == string.Empty ? false : true;
            item.Id = int.Parse(strings[1]);
            item.Title = strings[3];
            item.CreatedAt = DateTime.Parse(strings[2]);

            return item;
        }
    }
}
