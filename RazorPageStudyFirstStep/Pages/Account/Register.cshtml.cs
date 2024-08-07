using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPageStudyFirstStep.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public RegisterModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

