using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity,true);
        }

        public Task<Testimonial> TGetByID(int id)
        {
            return _testimonialDal.GetByID(id, true);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList(true);
        }

        public void TInsert(Testimonial entity)
        {
            _testimonialDal.Insert(entity, true);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity, true);
        }
    }
}
