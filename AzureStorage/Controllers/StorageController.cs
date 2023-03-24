using AzureStorage.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureStorage.Controllers
{
    public class StorageController : Controller
    {
        // GET: StorageController/Create
        public ActionResult Calculate()
        {
            return View();
        }

        // POST: StorageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(Storage storage)
        {
            ViewBag.StorageCost = storage.StorageCost;
            return View(storage);
        }
    }
}
