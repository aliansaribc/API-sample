using Microsoft.AspNetCore.Mvc;
using reactAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace reactAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {

        [HttpGet]
        public JsonResult Get()
        {
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult(context.TblApiusers.OrderByDescending(a=>a.Id).ToList());
            return res;
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id,string token)
        {
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult("login:failed");
            var login = context.TblApilogins.Where(a=>a.Token == token && a.Expire >= DateTime.Now).FirstOrDefault();
            if (login != null)
            {
                res = new JsonResult(context.TblApiusers.Where(a => a.Id == id).FirstOrDefault());
            }            
            return res;
        }

        [HttpPost]
        public JsonResult Post(string fullName,string phone,string email,string postal,string address, string token)
        {            
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult("login:failed");
            var login = context.TblApilogins.Where(a => a.Token == token && a.Expire >= DateTime.Now).FirstOrDefault();
            if (login != null)
            {
                TblApiuser user = new TblApiuser();
                user.FullName = fullName;
                user.Phone = phone;
                user.Email = email;
                user.Postal = postal;
                user.Address = address;
                context.TblApiusers.Add(user);
                context.SaveChanges();
                res = new JsonResult(context.TblApiusers.OrderByDescending(a => a.Id).ToList());
            }
            return res;
        }

        [HttpPut]
        public JsonResult Put(int id, string fullName, string phone, string email, string postal, string address, string token)
        {
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult("login:failed");
            var login = context.TblApilogins.Where(a => a.Token == token && a.Expire >= DateTime.Now).FirstOrDefault();
            var user = context.TblApiusers.Where(a => a.Id == id).FirstOrDefault();
            if ((login != null)&&(user != null))
            {
                user.FullName = fullName;
                user.Phone = phone;
                user.Email = email;
                user.Postal = postal;
                user.Address = address;
                context.TblApiusers.Update(user);
                context.SaveChanges();
                res = new JsonResult(context.TblApiusers.OrderByDescending(a => a.Id).ToList());
            }
            return res;
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id, string token)
        {
            aliansaridbContext context = new aliansaridbContext();
            JsonResult res = new JsonResult("login:failed");
            var login = context.TblApilogins.Where(a => a.Token == token && a.Expire >= DateTime.Now).FirstOrDefault();
            if (login != null)
            {
                var user = context.TblApiusers.Where(a => a.Id == id).FirstOrDefault();
                context.Remove(user);
                context.SaveChanges();
                res = new JsonResult(context.TblApiusers.OrderByDescending(a => a.Id).ToList());
            }
            return res;
        }
    }
}