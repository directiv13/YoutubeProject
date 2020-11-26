using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
                using (var response = request.GetResponse())
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
        public JToken GetContents(string searchRequest)
        {
            string searchResult = GetSearchResult(searchRequest);

            var jObject = JObject.Parse(searchResult);
            var contents = jObject.SelectToken("$.contents.twoColumnSearchResultsRenderer.primaryContents.sectionListRenderer.contents[0].itemSectionRenderer.contents");
            var resultError = contents.SelectToken("$.[0].backgroundPromoRenderer.title.runs[0].text");
            //var searchRequestError = contents.SelectToken("$.[0].didYouMeanRenderer");

            if (resultError != null)
                return null;
            return contents;
        }
    }
}
