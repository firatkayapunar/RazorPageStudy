using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPageStudyFirstStep.Pages
{
    public class EditDeleteMember : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Surname { get; set; }
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public string MemberType { get; set; }
        public List<string> MemberTypes { get; set; }
        public string Result { get; set; }
        public void OnGet()
        {
            MemberTypes = new List<string> { "Admin", "User" };

            Name = "Fýrat";
            Surname = "Kayapunar";
            Age = 24;
            MemberType = "Admin";
        }

        //Handler ile bunu saðladýk. (asp-page-handler)
        
        //OnGet de bir handler method'dur. Razor Pages'de handler method'larý, sayfaya gelen belirli HTTP isteklerini iþlemek için kullanýlýr ve OnGet, OnPost, OnPut gibi metotlar bu istek türlerine yanýt verir. Her biri, belirli bir HTTP isteðinin nasýl iþleneceðini belirleyen metotlardýr.
        
        //Ayrýca, özel handler metotlarý da tanýmlayabilirsiniz, örneðin OnPostSave ve OnPostRemove gibi.Bu metotlar, belirli eylemler için özelleþtirilmiþtir ve asp-page-handler özniteliði ile kullanýlýr.
        
        public void OnPostSave()
        {
            MemberTypes = new List<string> { "Admin", "User" };
            Result = "Kaydedildi.";
        }
        public void OnPostRemove()
        {
            MemberTypes = new List<string> { "Admin", "User" };
            Result = "Kaldýrýldý.";
        }
    }
}

