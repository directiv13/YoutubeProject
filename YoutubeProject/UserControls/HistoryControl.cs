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
    public partial class HistoryControl : UserControl
    {
        private List<string> HistoryItemCollection;
        private Point StartItemPosition = new Point(0, 97);
        private int ItemPositionStep = 70;
        public HistoryControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void customCheckBox1_Click(object sender, EventArgs e)
        {

        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            HistoryItemCollection = new List<string>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void AddHistoryItem(string historyItem)
        {
            HistoryItemCollection.Add(historyItem);
            if(HistoryItemCollection.Count < 6)
            {
                ShowLastHistoryItem(historyItem);
            }
        }
        private void ShowLastHistoryItem(string item)
        {
            this.Controls.Add(new HistoryBoxControl()
            {
                Location = StartItemPosition,
                CheckBoxText = item
            });
        }
    }
}
