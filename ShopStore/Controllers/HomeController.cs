using System;
using System.Web.Mvc;
using ShopStore.Repository;

namespace ShopStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [System.Web.Mvc.HttpGet]
        public ActionResult ViewShops()
        {
            var ishop = new ShopRepository();
            return View(ishop.GetShops());
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult Products()
        {
            var iproducts = new ProductRepository();
            var shopId = Request.Params["ShopId"];
            return View(iproducts.GetProducts(Convert.ToInt32(shopId)));
        }
    }
}
