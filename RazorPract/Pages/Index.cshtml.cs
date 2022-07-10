using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPract.Pages
{
    public class IndexModel : PageModel
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public void OnGet()
        {
            Age = 33;
            Name = "Sasha";
        }
    }
}