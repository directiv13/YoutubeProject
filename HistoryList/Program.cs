using System;

namespace HistoryList
{
    class Program
    {
        static void Main(string[] args)
        {
            HistoryList list = new HistoryList();

            list.AddFirst(new HistoryListItem("3"));
            list.AddFirst(new HistoryListItem("2"));
            list.AddLast(new HistoryListItem("4"));
            list.AddFirst(new HistoryListItem("1"));
            list.RemoveAt(2);
            list.InsertAt(3,new HistoryListItem("insert"));
            list.InsertAt(3,new HistoryListItem("insert2"));
            list.Print();
        }
    }
}
