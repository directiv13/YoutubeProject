using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeProject
{
    interface IScrapper
    {
        List<string> GetYoutubeVideos(HttpRequest requ);
        string MakeSearch(string searchRequset);
    }
}
