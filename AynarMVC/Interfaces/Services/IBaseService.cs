namespace AynarMVC.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        ICollection<T> GetAll();
        T GetById(int id);

        void Create(T item);

        void Update(T Item);

        void Delete(int Id);
    }
}
