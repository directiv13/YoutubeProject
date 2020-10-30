using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    interface IScrapper
    {
        List<string> GetThumbnails(string htmlQuery);
        List<string> GetTitles(string htmlQuery);
        List<string> GetVideoId(string htmlQuery);
        string GetSearchResult(string searchRequest);

    }
}
