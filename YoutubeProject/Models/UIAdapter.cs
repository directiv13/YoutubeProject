using DataAccess.Contexts;
using DataAccess.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace YoutubeProject
{
    class UIAdapter
    {
        IScrapper search;
        List<YoutubeVideo> youtubeVideos;
        public UIAdapter(IScrapper scrapper)
        {
            this.search = scrapper;
        }
        private List<YoutubeVideo> GetYoutubeVideos(string searchRequest)
        {
            youtubeVideos = new List<YoutubeVideo>(6);
            JToken contents = search.GetContents(ValidateSearchRequest(searchRequest));
            if (contents == null)
                return null;

            YoutubeVideoBuilder builder = new YoutubeVideoBuilder(contents);
            for (int i = 0; i < 6; i++)
            {
                youtubeVideos.Add(builder.CreateYoutubeVideo());
            }
            return youtubeVideos;
        }
        public async Task<List<YoutubeVideo>> GetYoutubeVideosAsync(string searchRequest)
        {
            return await Task.Run(() => GetYoutubeVideos(searchRequest));
        }
        private string ValidateSearchRequest(string str)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(str);
            List<string> chars = byteArray.Select(b => b.ToString("X2")).ToList();
            string result = "";
            foreach (string stri in chars)
            {
                result += "%" + stri;
            }
            result = result.Replace("%20", "+");

            return result;
        }
        public void AddSearchRequestDb(int userID,string request)
        {
            var mongoSearchDbService = Program.ServiceProvider.GetService<ISearchHistoryContext>();
            mongoSearchDbService.Create(new SearchHistoryItem
            {
                UserId = userID,
                SearchTerm = request
            });
        }
        public List<SearchHistoryItem> GetSearchHistory(int userID)
        {
            var mongoSearchDbService = Program.ServiceProvider.GetService<ISearchHistoryContext>();
            return mongoSearchDbService.Get(userID);
        }
        public void DeleteItem(string id)
        {
            var mongoSearchDbService = Program.ServiceProvider.GetService<ISearchHistoryContext>();
            mongoSearchDbService.Remove(id);
        }
    }
}
