using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reactAPI.Models;

namespace reactAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class loginController : ControllerBase
    {
        [HttpPost]
        public JsonResult Post(string userName,string password)
        {
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult("token:0");
            var user = context.TblApilogins.Where(a=> a.UserName==userName && a.Password==password).FirstOrDefault();
            if (user != null)
            {
                string token = makeToken();
                user.Token = token;
                user.Expire = DateTime.Now.AddMinutes(30);
                context.Update(user);   
                context.SaveChanges();
                res = new JsonResult("token:"+token); ;
            }            
            return res;
        }

        [HttpGet]
        public JsonResult get(string token)
        {
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult("token:0");
            var user = context.TblApilogins.Where(a => a.Token == token && a.Expire >= System.DateTime.Now).FirstOrDefault();
            if (user != null)
            {
                res = new JsonResult("token:" + user.Token);
            }
            return res;
        }

        private string makeToken()
        {
            var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var resultToken = new string(Enumerable.Repeat(allChar, 8).Select(token => token[random.Next(token.Length)]).ToArray());
            string authToken = resultToken.ToString();
            return authToken;
        }
    }
}
