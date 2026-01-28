using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PercipoBookChapter11.Context;
using PercipoBookChapter11.Models;

namespace PercipoBookChapter11.Pages.Customer
{
    public class IndexModel : PageModel
    {
        private readonly CustomerDbContext _context;

        public IndexModel(CustomerDbContext context)
        {
            _context = context;
        }

        public List<PercipoBookChapter11.Models.Customer> Customers { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Search { get; set; }

        public void OnGet()
        {
            var query = _context.Customers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(Search))
            {
                query = query.Where(c =>
                    c.Name.Contains(Search) ||
                    c.Email.Contains(Search));
            }

            Customers = query
                .OrderByDescending(c => c.CreatedAt)
                .ToList();
        }

        public IActionResult OnPostDelete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            customer.IsDeleted = true;
            _context.SaveChanges();

            return RedirectToPage();
        }
    }

}
