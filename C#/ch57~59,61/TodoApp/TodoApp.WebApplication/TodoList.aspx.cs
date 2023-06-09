﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TodoApp.WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayDate();
        }

        private void DisplayDate()
        {
            const string url = "";

            using (var client = new HttpClient())
            {
                // 데이터 전송
                var json = JsonConvert.SerializeObject(new Todo { Title = "HttpClient", IsDone = true });
                var post = new StringContent(json, Encoding.UTF8, "application/json");
                client.PostAsync(url, post).Wait();
                // 데이터 수신
                var response = client.GetAsync(url).Result;
                var result = response.Content.ReadAsStringAsync().Result;
                var todos = JsonConvert.DeserializeObject<List<Todo>>(result);

                // 필터링: LINQ로 함수형 프로그래밍 스타일 구현
                // Select(): map()
                //var q = from todo in todos
                //        select todo;
                // var q = todos.Select(t => t);
                var query = todos.AsQueryable<Todo>();
                
                if (DateTime.Now.Second % 2 == 0)
                {
                    query = query.Where(it => it.Id % 2 == 0);     // 짝수
                }
                else
                {
                    query = query.Where(it => it.Id % 2 == 1);      // 홀수
                }
                // 조건 처리
                query = query.Where(it => it.IsDone == false);

                // 정렬
                const string sortOrder = "Title";
                query = (sortOrder == "Title" ? query.OrderBy(it => it.Title) : query);


                var q = query.Select(t => new TodoViewModel     // Todo -> TodoViewModel로 재정의
                {
                    Title = t.Title, IsDone = t.IsDone
                });


                // 데이터 바인딩
                this.GridView1.DataSource = q;
                this.GridView1.DataBind();
            }
        }
    }

    public class TodoViewModel
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }
}