using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyProject.Data;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class ItemsController : Controller
    {

        private readonly MyAppContext _context;

        public ItemsController(MyAppContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _context.Items.ToListAsync();  // Fetch the list of items from the database
            return View(items);  // Pass the list to the view
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,name,price")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Items.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, name, price")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Items.Update(item);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public async Task <IActionResult> Delete(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(_x => _x.Id == id);
            return View(item);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Items.FindAsync(id);

            if (item != null)
            {
                _context.Items.Remove(item);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Item deleted successfully!";
            }
                return RedirectToAction("Index");
        }

        //public IActionResult Overview()
        //{
        //    var item = new Item() { name = "Keyboard" };
        //    return View(item);
        //}

        //public IActionResult Edit(int itemId) 
        //{
        //    return Content("ID: " + itemId);
        //}

        //public ViewResult Overview()
        //{
        //    return View();
        //}

        //public ContentResult Overview()
        //{
        //    var c = "Laptop";
        //    return Content(c);
        //}
    }
}
