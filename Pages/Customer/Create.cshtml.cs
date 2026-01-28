using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PercipoBookChapter11.Context;

namespace PercipoBookChapter11.Pages.Customer
{
    public class CreateModel : PageModel
    {
        private readonly CustomerDbContext _context;

        public CreateModel(CustomerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PercipoBookChapter11.Models.Customer Customer { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Customers.Add(Customer);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }

}
