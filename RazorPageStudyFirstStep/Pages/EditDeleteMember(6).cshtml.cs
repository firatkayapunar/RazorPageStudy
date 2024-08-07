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

            Name = "F�rat";
            Surname = "Kayapunar";
            Age = 24;
            MemberType = "Admin";
        }

        //Handler ile bunu sa�lad�k. (asp-page-handler)
        
        //OnGet de bir handler method'dur. Razor Pages'de handler method'lar�, sayfaya gelen belirli HTTP isteklerini i�lemek i�in kullan�l�r ve OnGet, OnPost, OnPut gibi metotlar bu istek t�rlerine yan�t verir. Her biri, belirli bir HTTP iste�inin nas�l i�lenece�ini belirleyen metotlard�r.
        
        //Ayr�ca, �zel handler metotlar� da tan�mlayabilirsiniz, �rne�in OnPostSave ve OnPostRemove gibi.Bu metotlar, belirli eylemler i�in �zelle�tirilmi�tir ve asp-page-handler �zniteli�i ile kullan�l�r.
        
        public void OnPostSave()
        {
            MemberTypes = new List<string> { "Admin", "User" };
            Result = "Kaydedildi.";
        }
        public void OnPostRemove()
        {
            MemberTypes = new List<string> { "Admin", "User" };
            Result = "Kald�r�ld�.";
        }
    }
}

