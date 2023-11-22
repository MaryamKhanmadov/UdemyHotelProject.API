using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity, true);
        }

        public async Task<Contact> TGetByID(int id)
        {
            return await _contactDal.GetByID(id, true);
        }

        public List<Contact> TGetList()
        {
            return _contactDal.GetList(true);
        }

        public void TInsert(Contact entity)
        {
            _contactDal.Insert(entity, true);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity, true);
        }
    }
}
