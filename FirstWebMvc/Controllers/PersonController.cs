using Microsoft.AspNetCore.Mvc;
using FirstWebMvc.Models;
namespace Net_Core_API
{
    public class PersonController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chào" + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();
        }
    }
}