using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeProject
{
    class YoutubeVideoBuilder
    {
        JToken contents;

        string thumbnail;
        string videoID;
        string title;
        string duration;
        string viewCount;
        string channelName;
        string publishedTime;

        public YoutubeVideoBuilder(JToken contents)
        {
            this.contents = contents.First;
        }
        private bool NextVideo()
        {
            if (contents.Next != null)
            {
                contents = contents.Next;
                return true;
            }
            return false;
        }

        public YoutubeVideo CreateYoutubeVideo()
        {
            JToken token = contents.SelectToken("$.videoRenderer.lengthText");
            //Відкидаємо прямі трансляції
            while (token == null)
            {
                if (NextVideo())
                {
                    token = contents.SelectToken("$.videoRenderer.lengthText");
                }
                else
                    return null;
            }

            this.thumbnail = contents.SelectToken("$.videoRenderer.thumbnail.thumbnails[0].url").Value<string>();
            this.videoID = contents.SelectToken("$.videoRenderer.videoId").Value<string>();
            this.title = contents.SelectToken("$.videoRenderer.title.runs[0].text").Value<string>();
            this.duration = token.SelectToken("$.simpleText").Value<string>();
            this.viewCount = contents.SelectToken("$.videoRenderer.shortViewCountText.simpleText").Value<string>();
            this.channelName = contents.SelectToken("$.videoRenderer.ownerText.runs[0].text").Value<string>();
            this.publishedTime = contents.SelectToken("$.videoRenderer.publishedTimeText.simpleText").Value<string>();
            //Переходимо до наступного відео у пошуку
            NextVideo();
            return new YoutubeVideo(videoID)
            {
                ThumbnailURL = thumbnail,
                Title = title,
                Duration = duration,
                ViewCount = viewCount,
                ChannelName = channelName,
                PublishedTime = publishedTime
            };
        }
    }
}
