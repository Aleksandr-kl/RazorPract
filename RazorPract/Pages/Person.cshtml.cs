using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPract.Pages
{
    public class PersonModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Введите данные";
        }
        public void OnPost(string name, int age)
        {
            Message = $"Имя: {name} Возраст: {age}";
        }
    }
}
