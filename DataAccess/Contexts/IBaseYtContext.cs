using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Contexts
{
    public interface IBaseYtContext
    {
        List<YtHistoryItem> Get();
        YtHistoryItem Get(string id);

        YtHistoryItem Create(YtHistoryItem item);

        void Update(string id, YtHistoryItem item);

        void Remove(YtHistoryItem item);

        void Remove(string id);
    }
}
