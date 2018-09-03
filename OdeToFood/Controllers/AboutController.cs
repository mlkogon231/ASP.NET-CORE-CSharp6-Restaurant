using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("[controller]/[action]")]
        public string Phone()
        {
            return "1+555-555-4444";
        }

        public string Address()
        {
            return "US";
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}