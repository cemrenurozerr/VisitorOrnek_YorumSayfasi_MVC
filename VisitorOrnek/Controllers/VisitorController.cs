using Microsoft.AspNetCore.Mvc;
using VisitorOrnek.Data;
using VisitorOrnek.Models;

namespace VisitorOrnek.Controllers
{
    public class VisitorController : Controller
    {
        public IActionResult Index()
        {
            VisitorVM visitorVM = new VisitorVM();
			visitorVM.Visitors=Listeler.visitors;
            return View(visitorVM);
        }
        [HttpPost]
		public IActionResult Index(VisitorVM visitorVM)
		{
            visitorVM.Visitor.ID = Listeler.visitors.Count + 1;
            visitorVM.Visitor.CreatedDate=DateTime.Now;
            Listeler.visitors.Add(visitorVM.Visitor);
            TempData["result"] = "Yorumunuz Kaydedildi.";
			return RedirectToAction(nameof(Index));
		}
	}
}
