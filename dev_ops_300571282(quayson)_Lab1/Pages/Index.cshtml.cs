using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;  // Needed for date formatting

namespace MyCoreApp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            // Add current date/time to ViewData
            //added exlamiaitons on the index.cshtml
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;
        }
    }
}
