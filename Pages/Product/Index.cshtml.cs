using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PercipoBookChapter11.Context;
using PercipoBookChapter11.Models;

namespace PercipoBookChapter11.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly CustomerDbContext _context;

        public IndexModel(CustomerDbContext context)
        {
            _context = context;
        }

        public List<PercipoBookChapter11.Models.Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Products
                .OrderByDescending(p => p.CreatedAt)
                .ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return NotFound();

            product.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
