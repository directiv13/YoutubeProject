using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    class HistoryListItem
    {
        HistoryListItem left;
        HistoryListItem right;
        
        public string Data { get; set; }

        public HistoryListItem()
        { }

        public HistoryListItem Next 
        { 
            get { return right; }
            set { right = value; }
        }
        public HistoryListItem Previous { get { return left; } }

    }
}
