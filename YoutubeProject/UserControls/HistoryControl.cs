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
        private List<HistoryBoxControl> HistoryBoxCollection;
        private Point FirstItemPosition = new Point(0, 97);
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
            foreach (HistoryBoxControl item in HistoryBoxCollection)
                item.Location = new Point(0, item.Location.Y + ItemPositionStep);
            HistoryBoxCollection.Add(new HistoryBoxControl()
            {
                Location = FirstItemPosition,
                CheckBoxText = historyItem
            });
        }
        public void DeleteSelectedItems()
        {

        }
    }
}
