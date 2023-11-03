using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task Insert(T entity, bool tracking = true);
        Task Delete(T entity, bool tracking = true);
        Task Update(T entity, bool tracking = true);
        List<T> GetList(bool tracking = true);
        Task<T> GetByID(int id, bool tracking = true);
    }
}
