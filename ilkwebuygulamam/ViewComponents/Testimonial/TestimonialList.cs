using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ilkwebuygulamam.ViewComponents.Contact
{
    public class TestimonialList : ViewComponent
    {
        TestimonialManager eestimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = eestimonialManager.TGetList();
            return View(values);
        }
    }
}
