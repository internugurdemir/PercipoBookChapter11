using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PercipoBookChapter11.Context;
using PercipoBookChapter11.Models;

namespace PercipoBookChapter11.Pages
{
    public class CustomerForMemoryModel : PageModel
    {
        private readonly CustomerDbForMemoryContext _context;

        public CustomerForMemoryModel(CustomerDbForMemoryContext context)
        {
            _context = context;
        }

        public List<CustomerForMemory> CustomerForMemorys { get; set; } = new();

        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
            CustomerForMemorys = _context.Customers.ToList();
        }

        public IActionResult OnPost()
        {
            _context.Customers.Add(new CustomerForMemory
            {
                Name = Name
            });

            _context.SaveChanges();

            return RedirectToPage();
        }
    }
}
