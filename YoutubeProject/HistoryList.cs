using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    class HistoryList
    {
        HistoryListItem head;
        HistoryListItem tail;

        public HistoryList()
        {

        }

        #region Public Methods
        public void Add()
        {

        }
        public bool RemoveAt(int index)
        {
            HistoryListItem current = head;
            for (int i = 0; i < index && current != null; i++)
            {
                current = current.Next;
            }
            if (current == null)
                return false;
            current.Previous.Next = current.Next;
            return true;
        }

        #endregion
    }
}
