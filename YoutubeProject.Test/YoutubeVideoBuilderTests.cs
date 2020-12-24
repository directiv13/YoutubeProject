using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;

namespace YoutubeProject.Test
{
    [TestClass]
    public class YoutubeVideoBuilderTests
    {
        [TestMethod]
        public void CreateYoutubeVideod_RightRequest_Test()
        {
            string request = "English+request";

            YoutubeSearch searcher = new YoutubeSearch();
            JToken contents = searcher.GetContents(request);
            YoutubeVideoBuilder youtubeVideoBuilder = new YoutubeVideoBuilder(contents);

            Assert.IsInstanceOfType(youtubeVideoBuilder.CreateYoutubeVideo(), typeof(YoutubeVideo));
        }
    }
}
