//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace RazorPageStudyFirstStep.Pages
//{
//    public class IndexModel : PageModel
//    {
//        private readonly ILogger<IndexModel> _logger;

//        public IndexModel(ILogger<IndexModel> logger)
//        {
//            _logger = logger;
//        }

//        public void OnGet()
//        {

//        }
//    }
//}


using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace MyApp.Pages
{
    public class IndexModel : PageModel
    {
        public string CurrentTime { get; private set; }

        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}

