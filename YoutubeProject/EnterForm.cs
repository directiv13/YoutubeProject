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
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(0, 123, 123, 123);
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(255, 58, 58, 58);
        }
        private void EnterForm_Load(object sender, EventArgs e)
        {
            registrationControl1.Visible = false;
            logInControl1.Visible = false;
        }
        private void logButton_Click(object sender, EventArgs e)
        {
            logInControl1.Visible = true;
            logInControl1.BringToFront();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            registrationControl1.Visible = true;
            registrationControl1.BringToFront();
        }
    }
}
