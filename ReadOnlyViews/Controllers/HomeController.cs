namespace Levelnis.Learning.ReadOnlyViews.Controllers
{
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new ReadOnlyViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ReadOnlyViewModel model)
        {
            model.IsReadonly = true;
            return View(model);
        }
    }
}