using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class RoomManager : IRoomService
    {
        private readonly IRoomDal _roomDal;

        public RoomManager(IRoomDal roomDal)
        {
            _roomDal = roomDal;
        }

        public void TDelete(Room entity)
        {
            _roomDal.Delete(entity, true);
        }

        public async Task<Room> TGetByID(int id)
        {
            return await _roomDal.GetByID(id, true);
        }

        public List<Room> TGetList()
        {
            return _roomDal.GetList(true);
        }

        public void TInsert(Room entity)
        {
            _roomDal.Insert(entity, true);
        }

        public void TUpdate(Room entity)
        {
            _roomDal.Update(entity, true);
        }
    }
}
