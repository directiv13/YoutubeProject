using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Contexts
{
    public interface IBaseYtContext <T>
        where T: YtHistoryItemBase
    {
        List<T> Get();
        T Get(string id);

        T Create(T item);

        void Update(string id, T item);

        void Remove(T item);

        void Remove(string id);
    }
}
