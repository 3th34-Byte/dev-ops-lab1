using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MyCoreApp.Pages   // <-- MUST match your project folder
{
    public class PrivacyModel : PageModel
    {
        // Make it nullable to avoid "non-nullable property" errors
        public string? TimeStamp { get; private set; }

        public void OnGet()
        {
            // Set the current date for display in Razor
            TimeStamp = DateTime.Now.ToString("D");
        }
    }
}

