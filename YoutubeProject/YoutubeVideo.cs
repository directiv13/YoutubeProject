using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace YoutubeProject
{
    class YoutubeVideo
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
        public async void Download(DownloadingFormat format, string folderPath)
        {
            try
            {
                var youtube = YouTube.Default;
                var video = await youtube.GetVideoAsync("https://wwww.youtube.com/watch?v=" + VideoID);
                switch (format)
                {
                    case DownloadingFormat.MP3:
                        File.WriteAllBytes(folderPath + @"\" + video.Title + ".mp3", await video.GetBytesAsync());
                        MessageBox.Show("READY");
                        break;
                    case DownloadingFormat.MP4:
                        File.WriteAllBytes(folderPath + @"\" + video.Title + ".mp4", await video.GetBytesAsync());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public enum DownloadingFormat:byte
        {
            MP3 = 1,
            MP4 = 2
        }
    }
}
