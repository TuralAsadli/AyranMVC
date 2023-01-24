using AynarMVC.DAL;
using AynarMVC.Models;
using AynarMVC.Models.Base;

namespace AynarMVC.Repositories
{
    public class EmployeeRepository : BaseRepository
    {
        AynarDbContext _db;
        public EmployeeRepository(AynarDbContext db)
        {
            _db = db;
        }

        public void Create(BaseItem Item)
        {
            _db.Employees.Add((Employee)Item); 
            _db.SaveChanges();
        }

        public void Delete(int Id)
        {
            _db.Employees.FirstOrDefault(e => e.Id == Id);
            _db.SaveChanges();
        }

        public ICollection<Employee> GetAll()
        {
            return _db.Employees.ToList();
        }

        public BaseItem GetById(int Id)
        {
            return _db.Employees.FirstOrDefault(x => x.Id == Id);
        }

        public void Update(BaseItem item)
        {
            _db.Employees.Update((Employee)item);
            _db.SaveChanges();
        }
    }
}
