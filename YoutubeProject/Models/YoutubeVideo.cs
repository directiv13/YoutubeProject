using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExtractor;

namespace YoutubeProject
{
    public class YoutubeVideo
    {
        public string ThumbnailURL { get; set; }
        public string VideoID { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string ViewCount { get; set; }
        public string ChannelName { get; set; }
        public string PublishedTime { get; set; }
        public YoutubeVideo(string videoID)
        {
            this.VideoID = videoID;
        }
        public async Task DownloadAsync(DownloadingFormat downloadinfFormat, string folderPath)
        {
            var youtube = new YoutubeClient();
            StreamManifest streamManifest = await youtube.Videos.Streams.GetManifestAsync(VideoID);
            string format;
            IStreamInfo streamInfo;
            switch (downloadinfFormat)
            {   
                case DownloadingFormat.MP3:
                    streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();
                    format = "mp3";
                    break;
                case DownloadingFormat.MP4:
                    streamInfo = streamManifest.GetMuxed().WithHighestVideoQuality();
                    format = "mp4";
                    break;
                default:
                    streamInfo = null;
                    format = string.Empty;
                    break;
            }
            if (streamInfo != null)
            {
                // Get the actual stream
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo);

                // Download the stream to file
                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{folderPath}/{Title}.{format}");
            }

        }
        public enum DownloadingFormat : byte
        {
            MP3 = 1,
            MP4 = 2
        }
    }
}
