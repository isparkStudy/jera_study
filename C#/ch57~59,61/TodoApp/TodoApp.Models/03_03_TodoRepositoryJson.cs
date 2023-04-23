using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TodoApp.Models
{
    public class TodoRepositoryJson : ITodoRepository
    {
        private readonly string _filePath;
        private static List<Todo> _todos = new List<Todo>();

        public TodoRepositoryJson(string filePath = @"C:\C#\7day\Todos.json")
        {
            this._filePath = filePath;
            var todos = File.ReadAllText(filePath, Encoding.Default);
            // 문자열이었던 todos를 List<Todo> 형태로 _todos에 담아라
            _todos = JsonConvert.DeserializeObject<List<Todo>>(todos);
        }

        public void Add(Todo model)
        {
            model.Id = _todos.Max(t => t.Id) + 1;
            _todos.Add(model);

            // Json 파일 저장
            string json = JsonConvert.SerializeObject(_todos, Formatting.Indented);     // C# 객체를 Json으로 변경
            File.WriteAllText(_filePath, json);     // _filePath에 json을 넣어라
        }

        public List<Todo> GetAll()
        {
            return _todos.ToList();
        }
    }

}
