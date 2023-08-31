namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T: class
    {
        void TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        Task<List<T>> TGetList();
        Task<T> TGetByID(Guid id);
    }
}
