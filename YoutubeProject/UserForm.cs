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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            searchResult1.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(194, 197, 209, 82);
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResult1.SearchRequest = searchText.Text;
            searchResult1.ShowResult();
            searchResult1.BringToFront();
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
    }
}
