using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace RazorPagesIntro.Pages
{
    public class Indexv2Model : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";

        public void OnGet()
        {
            ViewData["Message"] = "Welcome to my Razor Pages tutorial!";
            Message += $" Server time is {DateTime.Now}";
        }
    }
}