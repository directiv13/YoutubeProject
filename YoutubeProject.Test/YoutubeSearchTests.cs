using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace YoutubeProject.Test
{
    [TestClass]
    public class YoutubeSearchTests
    {
        [TestMethod]
        public void GetSearchResult_EnglishInput_Test()
        {
            string input = "English+input";

            YoutubeSearch searcher = new YoutubeSearch();
            Assert.IsNotNull(searcher.GetSearchResult(input));
        }
        [TestMethod]
        public void GetSearchResult_CyrillicInput_Test()
        {
            string input = "Русский+ввод";

            YoutubeSearch searcher = new YoutubeSearch();
            Assert.IsNotNull(searcher.GetSearchResult(input));
        }
        [TestMethod]
        public void GetContents_EnglishInput_Test()
        {
            string input = "English+input";

            YoutubeSearch searcher = new YoutubeSearch();;
            Assert.IsNotNull(searcher.GetContents(input));
        }
        [TestMethod]
        public void GetContents_CyrillicInput_Test()
        {
            string input = "Русский+ввод";

            YoutubeSearch searcher = new YoutubeSearch();
            Assert.IsNotNull(searcher.GetContents(input));
        }
        [TestMethod]
        public void GetContents_IncorrectInput_Test()
        {
            string input = "iug1b413g4ib";

            YoutubeSearch searcher = new YoutubeSearch();
            Assert.IsNull(searcher.GetContents(input));
        }
    }
}
