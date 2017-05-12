using System.Collections.Generic;

namespace MiniORM
{
    public interface IDbContext
    {
        bool Persist(object entity);

        T FindById<T>(int id);

        IEnumerable<T> FindAll<T>();

        IEnumerable<T> FindAll<T>(string where);

        T FindFirst<T>();

        T FindFirst<T>(string where);

        void Delete<T>(object entity);

        void DeleteById<T>(int id);
    }
}
