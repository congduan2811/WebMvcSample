using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using WebMvcSample.Current;
using WebMvcSample.Current.Core;
using System.Net.Http.Formatting;

namespace WebMvcSample.Controllers
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult LuuThemMoi(Movie item)
        {
             return Json(item, JsonRequestBehavior.AllowGet); 
        }

        [HttpPost]
        public string SearchAccount()
        {
            string dataObjects = "";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:8085/api/Account/Search");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync("?name=&orderStart=0&orderfinish=100").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                dataObjects = response.Content.ReadAsAsync<string>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                //dataObjects.List = 
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            //Make any other calls using HttpClient here.

            //Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            client.Dispose();

            return dataObjects;
        }
    }
}