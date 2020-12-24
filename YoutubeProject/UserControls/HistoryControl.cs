﻿using DataAccess.Models;
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
        private int UserID { get; set; }
        private List<SearchHistoryItem> SearchHistoryCollection { get; set; }
        private Point NextItemPosition = new Point(0, 0);
        private int ItemPositionStep = 70;
        public HistoryControl()
        { 
            InitializeComponent(); 
        }
        /*public HistoryControl(int userID)
        {
            UserID = userID;
            InitializeComponent();
        }*/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void customCheckBox1_Click(object sender, EventArgs e)
        {

        }
        private void HistoryControl_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void AddHistoryBoxControl(string text)
        {
            panel2.Height += ItemPositionStep;
            panel2.Controls.Add(new HistoryBoxControl()
            {
                Location = NextItemPosition,
                CheckBoxText = text
            });

            NextItemPosition.Y += ItemPositionStep;
        }
        private void LoadHistory()
        {
            ReturnDefault();

            SearchHistoryCollection = Program.Adapter.GetSearchHistory(5);
            foreach (var item in SearchHistoryCollection)
            {
                AddHistoryBoxControl(item.SearchTerm);
            }
        }
        private void HistoryControl_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                LoadHistory();
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HistoryBoxControl[] historyBoxCollection = panel2.Controls.OfType<HistoryBoxControl>().ToArray();
            for (int i = 0; i < historyBoxCollection.Length; i++)
            {
                if (historyBoxCollection[i].IsChecked)
                {
                    Program.Adapter.DeleteItem(SearchHistoryCollection[i].Id);
                }
            }
            LoadHistory();
        }
        private void ReturnDefault()
        {
            if (SearchHistoryCollection != null)
                SearchHistoryCollection.Clear();
            panel2.Controls.Clear();
            panel2.Height = 0;
            NextItemPosition = new Point(0, 0);
        }
    }
}
