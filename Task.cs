using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TodoList
{
    internal class Task
    {
        [JsonInclude]
        private readonly int _id;
        [JsonInclude]
        private readonly string name;
        [JsonInclude]
        private readonly DateTime deadline;
        [JsonInclude]
        private readonly string priority;
        [JsonInclude]
        private bool cancelled = false;
        [JsonInclude]
        private bool completed = false;
        private static List<Task> taskList = new List<Task>();

        public Task (string name, DateTime deadline, string priority)
        {
            this._id = Task.taskList.Count+1;
            this.name = name;
            this.deadline = deadline;
            this.priority = priority;
            taskList.Add(this);
            
        }

        public static List<Task> GetTasks() { return taskList; }
        public int GetID () { return _id; }
        public string GetName () { return name; }
        public DateTime GetDeadline () { return deadline; }
        public string GetPriority() { return priority; }
        public bool IsCompleted() { return completed; }
        public bool IsCancelled() { return cancelled; }
        public void SetCompleted() { completed = true;}
        public void SetCancelled() { cancelled = true; }

        public static Task GetTaskFromId(int id)
        {
            Task task = Task.taskList.FirstOrDefault(el => el._id == id);
            return task;
        }

        public static void SaveTasks(string filePath) { 
            string jsonString = JsonSerializer.Serialize(taskList); 
            File.WriteAllText(filePath, jsonString); 
        }
        public static void LoadTasks(string filePath)
        { 
            if (File.Exists(filePath)) 
            { 
                string jsonString = File.ReadAllText(filePath); 
                taskList = JsonSerializer.Deserialize<List<Task>>(jsonString) ?? new List<Task>(); 
            } 
        }

    }
}
