using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPract.Pages
{
    public class PersonModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "������� ������";
        }
        public void OnPost(string name, int age)
        {
            Message = $"���: {name} �������: {age}";
        }
    }
}
