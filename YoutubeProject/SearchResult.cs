using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeProject
{
    public partial class SearchResult : UserControl
    {
        YoutubeSearch search;
        List<YoutubeVideo> youtubeVideos;
        private Button[] videoButtonCollection
        {
            get
            {
                return new Button[] { videoButton0, videoButton1, videoButton2, videoButton3, videoButton4, videoButton5 };
            }
            set
            {
                videoButtonCollection = value;
            }
        }
        private Button[] audioButtonCollection
        {
            get
            {
                return new Button[] { audioButton0, audioButton1, audioButton2, audioButton3, audioButton4, audioButton5 };
            }
            set
            {
                audioButtonCollection = value;
            }
        }
        public Label[] titleBoxCollection
        {
            get
            {
                return new Label[] { title0, title1, title2, title3, title4, title5 };
            }
            set
            {
                titleBoxCollection = value;
            }
        }
        public Label[] channelNameCollection
        {
            get
            {
                return new Label[] { channelName0, channelName1, channelName2, channelName3, channelName4, channelName5 };
            }
            set
            {
                channelNameCollection = value;
            }
        }
        public Label[] viewCountCollection
        {
            get { return new Label[] { viewCount0, viewCount1, viewCount2, viewCount3, viewCount4, viewCount5 }; }
            set { viewCountCollection = value; }
        }
        public Label[] publishedTimeCollection
        {
            get { return new Label[] { dataLabel0, dataLabel1, dataLabel2, dataLabel3, dataLabel4, dataLabel5 }; }
            set { publishedTimeCollection = value; }
        }
        public Label[] durationCollection
        {
            get { return new Label[] { durationLabel0, durationLabel1, durationLabel2, durationLabel3, durationLabel4, durationLabel5 }; }
            set { durationCollection = value; }
        }
        private PictureBox[] pictureBoxCollection
        {
            get
            {
                return new PictureBox[] { pictureBox0, pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            }
            set
            {
                pictureBoxCollection = value;
            }
        }
        public string SearchRequest { get; set; }
        public SearchResult()
        {
            InitializeComponent();
        }

        private void buttonMP3_click(object sender, EventArgs e)
        {

            for (int i = 0; i < audioButtonCollection.Length; i++)
            {
                if (sender.Equals(audioButtonCollection[i]))
                {
                    using (FolderBrowserDialog saveDialog = new FolderBrowserDialog())
                    {
                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (youtubeVideos[i] != null)
                            {
                                youtubeVideos[i].Download(YoutubeVideo.DownloadingFormat.MP3, saveDialog.SelectedPath);
                            }
                        }
                    }
                    return;
                }
            }
        }
        public void ShowResult()
        {
            youtubeVideos = search.GetYoutubeVideos(StringToUtf8(SearchRequest));

            for (int i = 0; i < youtubeVideos.Count() && i < 6; i++)
            {
                //get thumbnail
                this.pictureBoxCollection[i].ImageLocation = youtubeVideos[i].ThumbnailURL;
                //get title
                this.titleBoxCollection[i].Text = youtubeVideos[i].Title;
                this.channelNameCollection[i].Text = youtubeVideos[i].ChannelName;
                this.viewCountCollection[i].Text = youtubeVideos[i].ViewCount;
                this.publishedTimeCollection[i].Text = youtubeVideos[i].PublishedTime;
                this.durationCollection[i].Text = youtubeVideos[i].Duration;
            }
        }
        private void SearchResult_Load(object sender, EventArgs e)
        {
            foreach (var pictureBox in pictureBoxCollection)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            search = new YoutubeSearch();
        }
        private void buttonMP4_click(object sender, EventArgs e)
        {
            for (int i = 0; i < videoButtonCollection.Length; i++)
            {
                if (sender.Equals(videoButtonCollection[i]))
                {
                    using (FolderBrowserDialog saveDialog = new FolderBrowserDialog())
                    {
                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            if (youtubeVideos[i] != null)
                            {
                                youtubeVideos[i].Download(YoutubeVideo.DownloadingFormat.MP4, saveDialog.SelectedPath);
                            }
                        }
                    }
                    return;
                }
            }
        }
        private string StringToUtf8(string str)
        {
            byte[] byteArray = Encoding.ASCII.GetBytes(str);
            List<string> chars = byteArray.Select(b => b.ToString("X2")).ToList();
            string result = "";
            foreach (string stri in chars)
            {
                result += "%" + stri;
            }
            result = result.Replace("%20","+");

            return result;
        }
    }
}
