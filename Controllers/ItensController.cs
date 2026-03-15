using Microsoft.AspNetCore.Mvc;
using ProjetoFênix.Models;
using ProjetoFênix.Services;

namespace ProjetoFênix.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IInventoryService _service;

        public ItemsController(IInventoryService service)
        {
            _service = service;
        }

        // GET /items
        public IActionResult Index()
        {
            var items = _service.GetAll();
            return View(items);
        }

        // POST /items/create
        [HttpPost]
        public IActionResult Create(Item item)
        {
            _service.Add(item);
            return RedirectToAction("Index");
        }

        // POST /items/edit/{id}
        [HttpPost]
        public IActionResult Edit(int id, Item item)
        {
            _service.Update(id, item);
            return RedirectToAction("Index");
        }

        // POST /items/delete/{id}
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}