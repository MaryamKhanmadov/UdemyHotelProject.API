using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service entity)
        {
            _serviceDal.Delete(entity, true);
        }

        public Task<Service> TGetByID(int id)
        {
            return _serviceDal.GetByID(id, true);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList(true);
        }

        public void TInsert(Service entity)
        {
            _serviceDal.Insert(entity, true);
        }

        public void TUpdate(Service entity)
        {
            _serviceDal.Update(entity, true);
        }
    }
}
