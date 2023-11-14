using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }
        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity, true);
        }

        public async Task<Booking> TGetByID(int id)
        {
            return await _bookingDal.GetByID(id, true);
        }

        public List<Booking> TGetList()
        {
            return _bookingDal.GetList(true);
        }

        public void TInsert(Booking entity)
        {
            _bookingDal.Insert(entity, true);
        }

        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity, true);
        }
        public void TBookingStatusChangeApproved(int id)
        {
            _bookingDal.BookingStatusChangeApproved(id);
        }

        public void TBookingStatusChangeCancel(int id)
        {
            _bookingDal.BookingStatusChangeCancel(id);
        }

        public void TBookingStatusChangeWait(int id)
        {
            _bookingDal.BookingStatusChangeWait(id);
        }
    }
}