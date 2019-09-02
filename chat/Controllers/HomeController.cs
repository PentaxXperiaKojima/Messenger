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
    public class HomeController : Controller
    {
        private readonly chatContext _context;

        public HomeController(chatContext context)
        {
            _context = context;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var tmp = _context.User.FirstOrDefault(m => m.Name == user.Name);
            if (tmp == null)
            {
                ModelState.AddModelError(string.Empty, "間違ってるぞ！");
                return View(user);
            }

            if (tmp.Pass != user.Pass)
            {
                ModelState.AddModelError(string.Empty, "間違ってるぞ！");
                return View(user);
            }

            //くっきー作成
            Claim[] claims = {
                    new Claim("Name", tmp.Name),
                    new Claim("Pass", tmp.Pass),
                    new Claim("UserId", tmp.UserId.ToString()),
                };

            var claimsIdentity = new ClaimsIdentity(
              claims, CookieAuthenticationDefaults.AuthenticationScheme);

            claimsIdentity.AddClaims(new[]
            {
                    new Claim(ClaimTypes.Role, "User")
            });

            HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                new AuthenticationProperties
                {
                    //永続ログイン
                    IsPersistent = true
                }
            );

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChatView(string id)
        {
            return ViewComponent("ChatView", id);
        }
    }

    [ViewComponent(Name = "ChatView")]
    public class ChatView : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private readonly chatContext _context;

        public ChatView(chatContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string id)
        {
            if (id != null)
            {
                id = id.Replace('-', '/');
            }
            var result = _context.Chat.Include(m => m.User).Where(x => x.Date.ToString("d") == id);
            return View(result);
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : Controller
    {

        private readonly chatContext _context;

        public ChatController(chatContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void PostAsync(Chat chat)
        {

            if (ModelState.IsValid)
            {
                chat.UserId = int.Parse(User.FindFirst("UserId").Value);
                chat.Date = DateTime.Now;
                      _context.Add(chat);
                      _context.SaveChanges();
            }

            return;
        }



        [HttpGet]
        public IActionResult Get(string date)
        {
            var a = ViewComponent("ChatView");
            return a;
        }

        [HttpGet("{id}")]
        public void GetAll(int id)
        {
            _context.Chat.Remove(_context.Chat.Where(m => m.ChatId == id).FirstOrDefault());
            _context.SaveChanges();
        }


    }

}
