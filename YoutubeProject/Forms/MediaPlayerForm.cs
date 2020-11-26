using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeProject
{
    public partial class MediaPlayerForm : Form
    {
        string videoID;
        public MediaPlayerForm(string videoID)
        {
            InitializeComponent();
            this.videoID = videoID;
        }
        private void MediaPlayerForm_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width = \"100%\" height = \"{1}\" src=\"{0}\"" +
            "frameborder=\"0\" allow=\"autoplay; encrypted-media\" scrolling=\"no\" allowfullscreen></iframe>" +
            "</body></html>";   
            var url = "https://www.youtube.com/embed/" + videoID;
            this.webBrowser1.DocumentText = string.Format(embed, url, webBrowser1.Height - 20);
            webBrowser1.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
