using AynarMVC.DAL;
using AynarMVC.Interfaces.Repositories;
using AynarMVC.Models.Base;

namespace AynarMVC.Repositories
{
    public class BaseRepository : IBaseRepository<BaseItem>
    {
        

        public void Create(BaseItem Item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<BaseItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseItem GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BaseItem item)
        {
            throw new NotImplementedException();
        }
    }
}
