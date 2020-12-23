namespace YoutubeProject
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchText = new YoutubeProject.PlaceHolderTextBox();
            this.searchResult1 = new YoutubeProject.SearchResult();
            this.historyControl1 = new YoutubeProject.HistoryControl();
            this.profileControl1 = new YoutubeProject.ProfileControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.collapseButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1707, 43);
            this.panel1.TabIndex = 0;
            // 
            // collapseButton
            // 
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.Image = ((System.Drawing.Image)(resources.GetObject("collapseButton.Image")));
            this.collapseButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.collapseButton.Location = new System.Drawing.Point(1553, 9);
            this.collapseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(27, 25);
            this.collapseButton.TabIndex = 2;
            this.collapseButton.UseVisualStyleBackColor = true;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1633, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 98);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.homeButton.Location = new System.Drawing.Point(57, 218);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(144, 68);
            this.homeButton.TabIndex = 2;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.homeButton.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // historyButton
            // 
            this.historyButton.FlatAppearance.BorderSize = 0;
            this.historyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.historyButton.Location = new System.Drawing.Point(57, 290);
            this.historyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(144, 68);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "History";
            this.historyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            this.historyButton.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.historyButton.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // profileButton
            // 
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.profileButton.Location = new System.Drawing.Point(57, 363);
            this.profileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileButton.Name = "profileButton";
            this.profileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.profileButton.Size = new System.Drawing.Size(144, 68);
            this.profileButton.TabIndex = 4;
            this.profileButton.Text = "Profile";
            this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            this.profileButton.MouseEnter += new System.EventHandler(this.Mouse_Enter);
            this.profileButton.MouseLeave += new System.EventHandler(this.Mouse_Leave);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(1567, 81);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(51, 39);
            this.searchButton.TabIndex = 51;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.infoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextBox.Location = new System.Drawing.Point(781, 395);
            this.infoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(925, 82);
            this.infoTextBox.TabIndex = 52;
            this.infoTextBox.Text = "Enter the search text to find and download \r\nhigh-quality videos from YouTube";
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel2.Location = new System.Drawing.Point(735, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 55;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.searchText.Location = new System.Drawing.Point(745, 80);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Name = "searchText";
            this.searchText.PlaceHolderText = "Enter a search request here...";
            this.searchText.Size = new System.Drawing.Size(889, 42);
            this.searchText.TabIndex = 54;
            this.searchText.Text = "Enter a search request here...";
            this.searchText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyUp);
            // 
            // searchResult1
            // 
            this.searchResult1.Location = new System.Drawing.Point(285, 201);
            this.searchResult1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResult1.Name = "searchResult1";
            this.searchResult1.SearchRequest = null;
            this.searchResult1.Size = new System.Drawing.Size(1421, 667);
            this.searchResult1.TabIndex = 53;
            // 
            // historyControl1
            // 
            this.historyControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.historyControl1.Location = new System.Drawing.Point(285, 201);
            this.historyControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyControl1.Name = "historyControl1";
            this.historyControl1.Size = new System.Drawing.Size(1421, 667);
            this.historyControl1.TabIndex = 56;
            // 
            // profileControl1
            // 
            this.profileControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.profileControl1.Location = new System.Drawing.Point(285, 201);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(1444, 673);
            this.profileControl1.TabIndex = 57;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.profileControl1);
            this.Controls.Add(this.historyControl1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchResult1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button collapseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox infoTextBox;
        private SearchResult searchResult1;
        private PlaceHolderTextBox searchText;
        private System.Windows.Forms.Panel panel2;
        private HistoryControl historyControl1;
        private ProfileControl profileControl1;
    }
}