using BookShop.Data.Repositories;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class StoragesController : Controller
    {
        private readonly IStoragesRepository _storagesRepository;

        public StoragesController(IStoragesRepository storagesRepository)
        {
            _storagesRepository = storagesRepository;
        }

        // GET: Storages
        public async Task<IActionResult> Index()
        {
            return View(await _storagesRepository.GetMany().ToListAsync());
        }

        // GET: Storages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storage = await _storagesRepository.GetAsync(m => m.Id == id);
            if (storage == null)
            {
                return NotFound();
            }

            return View(storage);
        }

        // GET: Storages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Storages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreateDate,CostPrice,Quantity")] Storage storage)
        {
            if (ModelState.IsValid)
            {
                await _storagesRepository.AddAsync(storage);
                return RedirectToAction(nameof(Index));
            }
            return View(storage);
        }

        // GET: Storages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storage = await _storagesRepository.GetAsync(s => s.Id == id);
            if (storage == null)
            {
                return NotFound();
            }
            return View(storage);
        }

        // POST: Storages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreateDate,CostPrice,Quantity")] Storage storage)
        {
            if (id != storage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _storagesRepository.UpdateAsync(storage);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await StorageExists(storage.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(storage);
        }

        // GET: Storages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var storage = await _storagesRepository.GetAsync(m => m.Id == id);
            if (storage == null)
            {
                return NotFound($"Record with id: {id} is not found");
            }

            return View(storage);
        }

        // POST: Storages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _storagesRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private Task<bool> StorageExists(int id)
        {
            return _storagesRepository.AnyAsync(e => e.Id == id);
        }
    }
}
