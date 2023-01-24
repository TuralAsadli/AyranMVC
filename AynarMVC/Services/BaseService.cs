using AynarMVC.DAL;
using AynarMVC.Interfaces.Repositories;
using AynarMVC.Interfaces.Services;

namespace AynarMVC.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        public void Create(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T Item)
        {
            throw new NotImplementedException();
        }
    }
}
