using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryList
{
    class HistoryList
    {
        HistoryListItem head;
        HistoryListItem tail;
        public HistoryList()
        {
            Count = 0;
        }
        public HistoryList(HistoryListItem[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
                this.AddLast(collection[i]);
            Count = collection.Length;
        }

        #region Public Methods
        public int Count { get; set; }
        public void AddLast(HistoryListItem item)
        {
            Count++;
            if (tail == null)
            {
                tail = head = item;
                return;
            }
            item.Previous = tail;
            tail.Next = item;
            tail = item;
        }
        public void AddFirst(HistoryListItem item)
        {
            Count++;
            if (head == null)
            {
                tail = head = item;
                return;
            }
            item.Next = head;
            head.Previous = item;
            head = item;
        }
        public bool RemoveAt(int index)
        {
            HistoryListItem current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
                if (current == null)
                    return false;
            }
            if (current == null)
                return false;
            current.Next.Previous = current.Previous;
            current.Previous.Next = current.Next;
            Count--;
            return true;
        }
        public bool InsertAt(int index, HistoryListItem item)
        {
            if (index > Count)
                return false;
            if (index == Count)
            {
                AddLast(item);
                return true;
            }
            if (index == 0)
            {
                AddFirst(item);
                return true;
            }


            HistoryListItem current = head;
            for(int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            item.Previous = current;
            item.Next = current.Next;
            current.Next.Previous = item;
            current.Next = item;

            return true;
        }
        public void Print()
        {
            HistoryListItem current = head;
            while (current != null)
            {
                Console.Write(current.Data + ", ");
                current = current.Next;
            }
        }
        #endregion
    }
}
