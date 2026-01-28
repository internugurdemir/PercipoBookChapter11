using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PercipoBookChapter11.Context;

namespace PercipoBookChapter11.Pages.Product
{

    public class CreateModel : PageModel
    {
        private readonly CustomerDbContext _context;

        public CreateModel(CustomerDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PercipoBookChapter11.Models.Product Product { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Products.Add(Product);
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
