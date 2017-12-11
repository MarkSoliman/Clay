using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using Clay.Models;
using Newtonsoft.Json;

namespace Clay.Controllers
{
    public class HomeController : Controller
    {
        string Baseurl = "http://127.0.0.1:8080/";
        public ActionResult Index()
        {
            /*
            List<Door> result = new List<Door>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl); 
                client.DefaultRequestHeaders.Clear();  

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

                HttpResponseMessage Res = await client.GetAsync("/api/Doors/GetDoors/building_id=0");  
  
                if (Res.IsSuccessStatusCode)  
                {  
                    var DoorResponse = Res.Content.ReadAsStringAsync().Result;  
  
                    //Deserializing the response recieved from web api and storing into the Employee list  
                    result = JsonConvert.DeserializeObject<List<Door>>(DoorResponse);  
  
                }  
            }
            */
            return View();
        }

    }
}
