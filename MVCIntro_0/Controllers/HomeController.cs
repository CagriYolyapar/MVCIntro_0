using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro_0.Controllers
{
    public class HomeController : Controller
    {
        //MVC'de Controller icerisinde bulunan Metotlara Action da denir...

        //MVC'de Action'lar cok önemlidir...Cünkü sizin BackEnd işlemlerinizi, HTTP protokolünüzde yapmak istediginiz tüm işlemleri Controller icerisindeki bu Action'lar yapar...

        //HTTP'de her Request'in bir tipi vardır...

        //Request yontemlerinden get sizin bir sayfayı ilk kez talep etmenizdir

        //Request yontemlerinden post ise sizin talep ettiginiz bir sayfanın get ile size gelmesinden sonra o sayfayı tekrar servera yollamanızdır

        //MVC'de bir Action'a HTTP request tipi vermezseniz , otomatik olarak HTTPGet yönteminde calısır...

        //MVC projesine ulasmaya calısıp bir route yazarken Controller ismi veya Action ismi olmayan yapılarsa Resource can not be found hatası alırsınız... Eger iki yapı da varsa ama ilgili View yoksa farklı bir hata alacaksınız...

        //MVC'de projenizin calısabilmesi icin sadece Controller ve Action yetmez...Action'in döndürebilecegi bir View olması gerekir...Yani bir sayfa...

       
        public ActionResult Index()
        {
            //Eger bir View() metodu argüman almamıssa icinde bulundugu Action'in ismi neyse onunla aynı isimde bir View döndürmeye calısır...

            //Ancak eger isterseniz View() metodunun farklı bir View döndürmesine metoda string bir argüman vererek saglayabilirsiniz...
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}