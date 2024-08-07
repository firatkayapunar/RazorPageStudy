using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPageStudyFirstStep.Pages
{
    //Hem controller hem model dosyas� gibi d���nebiliriz. Mvc'den farklar�ndan biridir.
    public class CreateMemberModel : PageModel
    {
        //Razor Pages'da, MVC'deki gibi metot parametreleri ile model binding yapam�yorsunuz. Bunun yerine, model binding i�lemi i�in BindProperty �zniteli�ini kullanarak modelinizi sayfa modeline ba�laman�z gerekiyor. Bu sayede, Razor Pages otomatik olarak form verilerini modelinize ba�layacakt�r.

        //[BindProperty] �zelli�i, ASP.NET Core Razor Pages'de form de�erlerini PageModel �zelliklerine ba�lamak i�in kullan�l�r. Bu �zellik, HTML formlar�ndan gelen kullan�c� girdilerini yakalama ve bu girdileri PageModel'deki ilgili �zelliklere otomatik olarak e�leme s�recini basitle�tirir.Bir form g�nderildi�inde, kullan�c� taraf�ndan girilen veriler otomatik olarak bu �zelliklere atan�r, bu da sunucu taraf� kodunda girdileri i�lemeyi kolayla�t�r�r.

        //ASP.NET MVC'de [BindProperty] �zelli�i yoktur. Bunun yerine, model binding i�lemleri i�in genellikle action method parametreleri kullan�l�r. ASP.NET MVC'de, bir form g�nderildi�inde, form verileri controller'daki action method parametrelerine otomatik olarak ba�lan�r.

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
            Result = null;
        }
        public void OnPost()
        {
            MemberTypes = new List<string> { "Admin", "User" };
            Result = $"{Name} {Surname} {Age} -{MemberType}";

            //Burada Two Way Binding oldu�u i�in iki tarafl� bir ba�lama s�z konusu. E�er bu de�erleri silmeden sayfaya tekrar g�nderirsek orada de�erler input �zerinde g�z�kmeye devam edecek. Onun i�in a�a��daki i�lemleri yapaca��m.
            Name = null;
            Surname = null;
            Age = 0;
            MemberType = null;
        }
    }
}

