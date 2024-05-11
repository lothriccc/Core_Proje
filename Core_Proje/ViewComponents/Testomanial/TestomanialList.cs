using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testomanial
{

    public class TestomanialList:ViewComponent
    {
        TestomanialManager testomanialManager = new TestomanialManager(new EfTestomanialDal());
        public IViewComponentResult Invoke()
        {
            var values = testomanialManager.TGetList();
            return View(values);
        }
    }
}
