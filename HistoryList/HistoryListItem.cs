using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryList
{
    class HistoryListItem
    {
        HistoryListItem left;
        HistoryListItem right;
        public string Data { get; set; }

        public HistoryListItem()
        { }
        public HistoryListItem(string data)
        {
            Data = data;
        }

        public HistoryListItem Next
        {
            get { return right; }
            set { right = value; }
        }
        public HistoryListItem Previous 
        { 
            get { return left; }
            set { left = value; }
        }
    }
}
