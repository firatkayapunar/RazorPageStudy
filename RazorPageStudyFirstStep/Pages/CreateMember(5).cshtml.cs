using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RazorPageStudyFirstStep.Pages
{
    //Hem controller hem model dosyasý gibi düþünebiliriz. Mvc'den farklarýndan biridir.
    public class CreateMemberModel : PageModel
    {
        //Razor Pages'da, MVC'deki gibi metot parametreleri ile model binding yapamýyorsunuz. Bunun yerine, model binding iþlemi için BindProperty özniteliðini kullanarak modelinizi sayfa modeline baðlamanýz gerekiyor. Bu sayede, Razor Pages otomatik olarak form verilerini modelinize baðlayacaktýr.

        //[BindProperty] özelliði, ASP.NET Core Razor Pages'de form deðerlerini PageModel özelliklerine baðlamak için kullanýlýr. Bu özellik, HTML formlarýndan gelen kullanýcý girdilerini yakalama ve bu girdileri PageModel'deki ilgili özelliklere otomatik olarak eþleme sürecini basitleþtirir.Bir form gönderildiðinde, kullanýcý tarafýndan girilen veriler otomatik olarak bu özelliklere atanýr, bu da sunucu tarafý kodunda girdileri iþlemeyi kolaylaþtýrýr.

        //ASP.NET MVC'de [BindProperty] özelliði yoktur. Bunun yerine, model binding iþlemleri için genellikle action method parametreleri kullanýlýr. ASP.NET MVC'de, bir form gönderildiðinde, form verileri controller'daki action method parametrelerine otomatik olarak baðlanýr.

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

            //Burada Two Way Binding olduðu için iki taraflý bir baðlama söz konusu. Eðer bu deðerleri silmeden sayfaya tekrar gönderirsek orada deðerler input üzerinde gözükmeye devam edecek. Onun için aþaðýdaki iþlemleri yapacaðým.
            Name = null;
            Surname = null;
            Age = 0;
            MemberType = null;
        }
    }
}

