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
        public string CheckBoxText
        {
            get { return customCheckBox1.CheckBoxText; }
            set
            {
                customCheckBox1.CheckBoxText = value;
            }
        }
        public bool IsChecked { 
            get
            {
                return customCheckBox1.IsChecked;
            }
            set
            {
                customCheckBox1.IsChecked = value;
            }
        }
        public HistoryBoxControl()
        {
            InitializeComponent();
        }

    }
}
