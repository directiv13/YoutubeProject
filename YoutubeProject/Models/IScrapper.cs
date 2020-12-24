using Newtonsoft.Json.Linq;

namespace YoutubeProject
{
    interface IScrapper
    {
        //List<string> GetThumbnails(string htmlQuery);
        //List<string> GetTitles(string htmlQuery);
        //List<string> GetVideoId(string htmlQuery);
        string GetSearchResult(string searchRequest);
        JToken GetContents(string searchRequest);
    }
}
