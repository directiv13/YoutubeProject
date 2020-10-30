using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using Jurassic.Library;
using Newtonsoft.Json.Linq;

namespace YoutubeProject
{
    class YoutubeSearch:IScrapper
    {
        public string GetSearchResult(string searchRequest)
        {
            try
            {
                String htmlQuery;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.youtube.com/results?search_query=" + searchRequest);
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        htmlQuery = reader.ReadToEnd();
                }

                var htmlDocument = new HtmlAgilityPack.HtmlDocument();
                htmlDocument.LoadHtml(htmlQuery);

                List<HtmlNode> scriptTags = htmlDocument.DocumentNode.Descendants()
                             .Where(n => n.Name == "script").ToList();

                var engine = new Jurassic.ScriptEngine();
                var result = engine.Evaluate("(function() { " + scriptTags[28].InnerText + " return ytInitialData; })()");
                string json = JSONObject.Stringify(engine, result);

                return json;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<string> GetThumbnails(string json)
        {
            try
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> thumbnailURLs = new List<string>();
                for (int i = 0; contents != null && i < 6; i++)
                {
                    thumbnailURLs.Add(contents.SelectToken("$.videoRenderer.thumbnail.thumbnails[0].url").Value<string>());
                    contents = contents.Next;
                }
                return thumbnailURLs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<string> GetTitles(string json)
        {
            try 
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> titles = new List<string>();
                for (int i = 0; contents != null && i < 6; i++)
                {
                    titles.Add(contents.SelectToken("$.videoRenderer.title.runs[0].text").Value<string>());
                    contents = contents.Next;
                }
                return titles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }  
        }
        public List<string> GetVideoId(string json)
        {
            try
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> videoIds = new List<string>();
                for (int i = 0; contents != null &&  i < 6; i++)
                {
                    videoIds.Add(contents.SelectToken("$.videoRenderer.videoId").Value<string>());
                    contents = contents.Next;
                }
                return videoIds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<string> GetChannelName(string json)
        {
            try
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> publishedTime = new List<string>();
                for (int i = 0; contents != null && i < 6; i++)
                {
                    publishedTime.Add(contents.SelectToken("$.videoRenderer.ownerText.runs[0].text").Value<string>());
                    contents = contents.Next;
                }
                return publishedTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<string> GetViewCount(string json)
        {
            try
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> viewCount = new List<string>();
                for (int i = 0; contents != null && i < 6; i++)
                {
                    viewCount.Add(contents.SelectToken("$.videoRenderer.shortViewCountText.simpleText").Value<string>());
                    contents = contents.Next;
                }
                return viewCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<string> GetDuration(string json)
        {
            try
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> duration = new List<string>();
                for (int i = 0; contents != null && i < 6; i++)
                {
                    duration.Add(contents.SelectToken("$.videoRenderer.lengthText.simpleText").Value<string>());
                    contents = contents.Next;
                }
                return duration;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<string> GetPublishedDate(string json)
        {
            try
            {
                var jObject = JObject.Parse(json);

                var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents[0]");

                List<string> publishedTime = new List<string>();
                for (int i = 0; contents != null && i < 6; i++)
                {
                    publishedTime.Add(contents.SelectToken("$.videoRenderer.publishedTimeText.simpleText").Value<string>());
                    contents = contents.Next;
                }
                return publishedTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public List<YoutubeVideo> GetYoutubeVideos(string searchRequest)
        {
            List<YoutubeVideo> video = new List<YoutubeVideo>();

            string json = GetSearchResult(searchRequest);
            List<string> videoID = GetVideoId(json);
            List<string> thumbnail = GetThumbnails(json);
            List<string> title = GetTitles(json);
            List<string> channelName = GetChannelName(json);
            List<string> viewCount = GetViewCount(json);
            List<string> duration = GetDuration(json);
            List<string> publishedTime = GetPublishedDate(json);

            for(int i = 0; i < videoID.Count() && i < 6; i++)
            {
                video.Add(new YoutubeVideo(videoID[i])
                {
                    ThumbnailURL = thumbnail[i],
                    Title = title[i],
                    ChannelName = channelName[i],
                    ViewCount = viewCount[i],
                    Duration = duration[i],
                    PublishedTime = publishedTime[i]
                });
            }
            return video;
        }
    }
}
