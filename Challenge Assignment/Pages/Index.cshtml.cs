using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Challenge_Assignment.Pages
{
    public class IndexModel : PageModel
    {
        // Property to pass the server time to the page
        public string? ServerTime { get; set; }

        public void OnGet()
        {
            // Get the actual server time and format it
            ServerTime = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}