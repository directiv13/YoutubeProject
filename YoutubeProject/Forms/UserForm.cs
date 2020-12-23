using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Contexts;

namespace YoutubeProject
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            searchResult1.Visible = false;
            historyControl1.Visible = false;
            profileControl1.Visible = false;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(0, 194, 197, 209);
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchText_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            searchResult1.SearchRequest = searchText.Text;

            if (!await searchResult1.GetYoutubeVideos())
            {
                infoTextBox.Text = "Invalid search query. =(";
            }
        }

        private void searchText_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    searchButton_Click(searchText, null);
                    break;
            }
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historyControl1.Visible = true;
        }

        private void HideAll()
        {

        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profileControl1.Visible = true;
        }
    }
}
