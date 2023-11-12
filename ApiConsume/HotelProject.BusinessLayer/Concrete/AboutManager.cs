using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity, true);
        }

        public async Task<About> TGetByID(int id)
        {
            return await _aboutDal.GetByID(id, true);
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList(true);
        }

        public void TInsert(About entity)
        {
            _aboutDal.Insert(entity, true);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity, true);
        }
    }
}
