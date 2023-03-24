using AzureStorage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AzureStorage.Controllers
{
    public class InstanceController : Controller
    {
        // GET: InstanceController/Create
        public ActionResult CalculateInstance()
        {
            ViewBag.InstanceSize = new SelectList(Instance.InstanceSizes);
            return View(new Instance { InstanceSize = "Small" });
        }

        // POST: InstanceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalculateInstance(Instance instance)
        {
            ViewBag.InstanceSize = new SelectList(Instance.InstanceSizes);
            ViewBag.Charge = instance.Charge;
            return View(instance);
        }
    }
}
