using Microsoft.AspNetCore.Mvc;

namespace simple_tracking.Controllers
{
    public class TestController : Controller
    {
        /// <summary>
        ///  localhost:7132/{id}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Index(string id)
        {
            var hanghoas = new List<Hanghoa> { 
                new Hanghoa{id = "1" , status1 = DateTime.Now, status2 = DateTime.Now, status3 = DateTime.Now, status4 = DateTime.Now},
                new Hanghoa{id = "2" , status1 = new DateTime(2001, 01, 06), status2 = new DateTime(2001, 01, 06), status3 = new DateTime(2001, 01, 06), status4 = new DateTime(2001, 01, 06)},
                new Hanghoa{id = "3" , status1 = new DateTime(2001, 12, 18), status2 = new DateTime(2001, 12, 18), status3 = new DateTime(2001, 12, 18), status4 = new DateTime(2001, 12, 18)}
            };

            foreach (var hanghoa in hanghoas)
            {
                if(hanghoa.id == id)
                {
                    ViewBag.hanghoa = hanghoa;
                }
            }

            if (ViewBag.hanghoa == null)
            {
                ViewBag.hanghoa = null;
            }
            return View();
        }
    }

    public class Hanghoa
    {
        public string id { get; set; }
        public DateTime status1 { get; set; }
        public DateTime status2 { get; set; }
        public DateTime status3 { get; set; }
        public DateTime status4 { get; set; }

    }
}
