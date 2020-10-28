using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
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

                List<string> thumbnailURLs = new List<string>(6);
                for (int i = 0; i < 6; i++)
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

        public List<string> GetTitles(string htmlQuery)
        {
            try 
            {
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }  
        }

        public List<string> GetVideoId(string htmlQuery)
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}
