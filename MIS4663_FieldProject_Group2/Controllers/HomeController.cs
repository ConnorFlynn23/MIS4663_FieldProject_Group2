using Microsoft.AspNetCore.Mvc;
using MIS4663_FieldProject_Group2.Data;
using MIS4663_FieldProject_Group2.Models;

namespace MIS4663_FieldProject_Group2.Controllers
{
    public class HomeController : Controller
    {
        DB_128040_group2Context db = new DB_128040_group2Context();
        public IActionResult Index()
        {
            return View();
        }
    }
}
