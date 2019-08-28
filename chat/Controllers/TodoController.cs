using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using chat.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace chat.Controllers
{
    public class TodoController : Controller
    {
        private readonly chatContext _context;

        public TodoController(chatContext context)
        {
            _context = context;
        }


        public IActionResult Todo()
        {
            
            return View();
        }

        public IActionResult TodoView()
        {

            return ViewComponent("TodoView", int.Parse(User.FindFirst("UserId").Value));
        }

        [HttpPost]
        public IActionResult TodoView(Todo todo , int id ,int delete)　
        {
            //IDが0なら登録処理
            if(id == 0)
            {
                if (todo.TodoContent == "")
                {
                    return null;
                }

                todo.UserId = int.Parse(User.FindFirst("UserId").Value);
                todo.AddDate = DateTime.Now;
                _context.Add(todo);
                _context.SaveChanges();

                return ViewComponent("TodoView", todo.UserId);
            }

            //Deleteに値があれば削除処理
            if(delete != 0)
            {
                _context.Todo.Remove(_context.Todo.Where(m => m.TodoId == delete).FirstOrDefault());
                _context.SaveChanges();
                return ViewComponent("TodoView", int.Parse(User.FindFirst("UserId").Value));
            }

            //更新処理
            var tmp = _context.Todo.Where(m => m.TodoId == id).FirstOrDefault();
            if (tmp.Complete == true)
            {
                tmp.Complete = false;
            }
            else
            {
                tmp.Complete = true;
            }
            _context.SaveChanges();
            return ViewComponent("TodoView", tmp.UserId);
        }
    }

    [ViewComponent(Name = "TodoView")]
    public class TodoView : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly chatContext _context;

        public TodoView(chatContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _context.Todo.Where(x => x.UserId == id);
            return View(result);
        }
    }
}
