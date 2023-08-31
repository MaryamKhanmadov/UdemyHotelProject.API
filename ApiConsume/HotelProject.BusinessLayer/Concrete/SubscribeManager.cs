using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class SubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public SubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void TDelete(Subscribe entity)
        {
            _subscribeDal.Delete(entity, true);
        }

        public Task<Subscribe> TGetByID(Guid id)
        {
            return _subscribeDal.GetByID(id, true);
        }

        public Task<List<Subscribe>> TGetList()
        {
            return _subscribeDal.GetList(true);
        }

        public void TInsert(Subscribe entity)
        {
            _subscribeDal.Insert(entity, true);
        }

        public void TUpdate(Subscribe entity)
        {
            _subscribeDal.Update(entity, true);
        }
    }
}
