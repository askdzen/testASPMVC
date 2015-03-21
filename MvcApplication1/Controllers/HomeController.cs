using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public List<string> strList = new List<string>();
        public void InitMess()
        {
            strList.Add("Modify this template to jump-start your ASP.NET MVC application.");
            strList.Add("Your app description page.");
            strList.Add("Your contact page.");

        }
        
        public string getMessages(int index)
        {
           
            this.InitMess();
            string output=strList[index];
            return output;
        }
        
        public ActionResult Index()
        {
            ViewBag.Message = getMessages(0);

            return View();
        }

        public ActionResult About()
        {
            
            
            ViewBag.Message = getMessages(1);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = getMessages(2);

            return View();
        }
    }
}
