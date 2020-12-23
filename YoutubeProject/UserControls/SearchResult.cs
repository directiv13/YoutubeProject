using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace YoutubeProject
{
    public partial class SearchResult : UserControl
    {
        UIAdapter searchResultAdapter;
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
        private async void buttonMP3_click(object sender, EventArgs e)
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
                               await youtubeVideos[i].DownloadAsync(YoutubeVideo.DownloadingFormat.MP3, saveDialog.SelectedPath);
                            }
                        }
                    }
                    return;
                }
            }
        }
        public async Task<bool> GetYoutubeVideos()
        {
            youtubeVideos = await searchResultAdapter.GetYoutubeVideosAsync(SearchRequest);
            if (youtubeVideos != null)
            {
                FillForm();
                this.Show();
                this.BringToFront();
                return true;
            }
            this.Hide();
            return false;
        }
        public void FillForm()
        {
            for (int i = 0; i < youtubeVideos.Count() && i < 6; i++)
            {
                //get thumbnail
                this.pictureBoxCollection[i].ImageLocation = youtubeVideos[i].ThumbnailURL;
                //get title
                this.titleBoxCollection[i].Text = youtubeVideos[i].Title;
                //get channel name
                this.channelNameCollection[i].Text = youtubeVideos[i].ChannelName;
                //get viewCount
                this.viewCountCollection[i].Text = youtubeVideos[i].ViewCount;
                //get published time
                this.publishedTimeCollection[i].Text = youtubeVideos[i].PublishedTime;
                //get duration
                this.durationCollection[i].Text = youtubeVideos[i].Duration;
            }
            this.Visible = true;
            this.Show();
        }
        private void SearchResult_Load(object sender, EventArgs e)
        {
            foreach (var pictureBox in pictureBoxCollection)
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            searchResultAdapter = new UIAdapter(new YoutubeSearch());
        }
        private async void buttonMP4_click(object sender, EventArgs e)
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
                                await youtubeVideos[i].DownloadAsync(YoutubeVideo.DownloadingFormat.MP4, saveDialog.SelectedPath);
                            }
                        }
                    }
                    return;
                }
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBoxCollection.Length; i++)
            {
                if(sender.Equals(pictureBoxCollection[i]))
                {
                    MediaPlayerForm player = new MediaPlayerForm(youtubeVideos[i].VideoID);
                    player.Text = youtubeVideos[i].Title;
                    player.Show();
                    return;
                }
            }
        }
    }
}