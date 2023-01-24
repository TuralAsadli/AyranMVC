using AynarMVC.Models.Base;

namespace AynarMVC.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseItem
    {
        ICollection<T> GetAll();
        T GetById(int Id);

        void Create(T Item);

        void Update(T item);

        void Delete(int Id);
    }
}
