using Ejercicio6.MVC.Project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio6.MVC.Project.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ApiView api;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://api-dolar-argentina.herokuapp.com/api/dolaroficial");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                api = JsonConvert.DeserializeObject<ApiView>(json);
            }

            return View(api);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}