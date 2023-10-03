using Microsoft.AspNetCore.Mvc;
using MIS4663_FieldProject_Group2.Data;

namespace MIS4663_FieldProject_Group2.Controllers
{
    public class HomeController : Controller
    {
        DbCon db = new DbCon();
        public IActionResult Index()
        {
            return View();
        }
    }
}
