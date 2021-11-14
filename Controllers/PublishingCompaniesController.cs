using BookShop.Data.Repositories;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class PublishingCompaniesController : Controller
    {
        private readonly IPublishingCompaniesRepository _publisherRepository;

        public PublishingCompaniesController(IPublishingCompaniesRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        // GET: PublishingCompanies
        public async Task<IActionResult> Index()
        {
            return View(await _publisherRepository.GetMany().ToListAsync());
        }

        // GET: PublishingCompanies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publishingCompany = await _publisherRepository.GetAsync(m => m.Id == id);
            if (publishingCompany == null)
            {
                return NotFound();
            }

            return View(publishingCompany);
        }

        // GET: PublishingCompanies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PublishingCompanies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] PublishingCompany publishingCompany)
        {
            if (ModelState.IsValid)
            {
                await _publisherRepository.AddAsync(publishingCompany);
                return RedirectToAction(nameof(Index));
            }
            return View(publishingCompany);
        }

        // GET: PublishingCompanies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publishingCompany = await _publisherRepository.GetAsync(pc => pc.Id == id);
            if (publishingCompany == null)
            {
                return NotFound();
            }
            return View(publishingCompany);
        }

        // POST: PublishingCompanies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] PublishingCompany publishingCompany)
        {
            if (id != publishingCompany.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _publisherRepository.UpdateAsync(publishingCompany);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await PublishingCompanyExists(publishingCompany.Id))
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
            return View(publishingCompany);
        }

        // GET: PublishingCompanies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var publishingCompany = await _publisherRepository.GetAsync(m => m.Id == id);
            if (publishingCompany == null)
            {
                return NotFound($"Record with id: {id} is not found");
            }

            return View(publishingCompany);
        }

        // POST: PublishingCompanies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _publisherRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private Task<bool> PublishingCompanyExists(int id)
        {
            return _publisherRepository.AnyAsync(e => e.Id == id);
        }
    }
}
