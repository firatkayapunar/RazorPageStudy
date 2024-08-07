using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace RazorPageStudyFirstStep.Pages
{
    public class LoginModel : PageModel
    {
        //Page Filter 
        //Filter sınıflarımızı burada yazmak zorundayız.
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            Debug.WriteLine($"{context.RouteData.Values["page"]} : OnPageHandlerExecuting");
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            Debug.WriteLine("Login Page : OnPageHandlerExecuted");
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public void OnGet()
        {
            Debug.WriteLine("Login Page : OnGet");
        }
    }
}

