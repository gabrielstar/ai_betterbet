using System.Collections.Generic;

namespace ai_betterbet.Repositories
{
    /*
     * This is generic repository for our Models
     */
    public interface IRepository<T>
    {
        string Create();
        string Create(T element);
        List<T> GetAll();
        List<T> GetAllByID(int ID);
        void DeleteAll();
    }
}