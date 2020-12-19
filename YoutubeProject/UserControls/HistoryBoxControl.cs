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
    public partial class HistoryBoxControl : UserControl
    {
        private string CheckBoxTextValue;
        public string CheckBoxText
        {
            get { return CheckBoxTextValue; }
            set
            {
                CheckBoxTextValue = value;
                customCheckBox1.CheckBoxText = CheckBoxTextValue;
            }
        }
        public HistoryBoxControl()
        {
            InitializeComponent();
        }
    }
}
