using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Web.Models.Books;
using Web.Models.Shared;

namespace Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly MyLibraryDb _context;
        private const int PageSize = 10;

        public BooksController()
        {
            _context = new MyLibraryDb();
        }

        // GET: Books
        public async Task<IActionResult> Index(BooksIndexViewModel model)
        {
            model.Pager ??= new PagerViewModel();
            model.Pager.CurrentPage = model.Pager.CurrentPage <= 0 ? 1 : model.Pager.CurrentPage;

            List<BooksViewModel> items = await _context.Books.Skip((model.Pager.CurrentPage - 1) * PageSize).Take(PageSize).Select(b => new BooksViewModel()
            {
                Id = b.Id,
                Author = b.Author,
                ISBN = b.ISBN,
                Pages = b.Pages,
                Price = b.Price,
                Title = b.Title

            }).ToListAsync();

            model.Items = items;
            model.Pager.PagesCount = (int)Math.Ceiling(await _context.Books.CountAsync() / (double)PageSize);

            return View(model);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            BooksCreateViewModel model = new BooksCreateViewModel();

            return View(model);
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BooksCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = new Book
                {
                    Price = model.Price,
                    ISBN = model.ISBN,
                    Author = model.Author,
                    Pages = model.Pages,
                    Title = model.Title
                };

                _context.Add(book);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            BooksEditViewModel model = new BooksEditViewModel
            {
                Id = book.Id,
                ISBN = book.ISBN,
                Author = book.Author,
                Pages = book.Pages,
                Title = book.Title,
                Price = book.Price
            };

            return View(model);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BooksEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Book book = new Book
                {
                    Id = model.Id,
                    ISBN = model.ISBN,
                    Author = model.Author,
                    Pages = model.Pages,
                    Title = model.Title,
                    Price = model.Price
                };

                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
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

            return View(model);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            Book book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
