
namespace YoutubeProject
{
    partial class HistoryBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryBoxControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customCheckBox1 = new YoutubeProject.CustomCheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 1);
            this.panel1.TabIndex = 0;
            // 
            // customCheckBox1
            // 
            this.customCheckBox1.CheckBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.customCheckBox1.CheckBoxBackHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(229)))));
            this.customCheckBox1.CheckBoxChar = "√";
            this.customCheckBox1.CheckBoxCharColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customCheckBox1.CheckBoxCharFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBox1.CheckBoxCharHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.customCheckBox1.CheckBoxCheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(229)))));
            this.customCheckBox1.CheckBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBox1.CheckBoxForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customCheckBox1.CheckBoxForeHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customCheckBox1.CheckBoxFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customCheckBox1.CheckBoxFrameHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.customCheckBox1.CheckBoxFrameStrength = 2;
            this.customCheckBox1.CheckBoxImage = ((System.Drawing.Image)(resources.GetObject("customCheckBox1.CheckBoxImage")));
            this.customCheckBox1.CheckBoxImageWidth = 100;
            this.customCheckBox1.CheckBoxSize = 25;
            this.customCheckBox1.CheckBoxText = "Max Korzh";
            this.customCheckBox1.Location = new System.Drawing.Point(24, 0);
            this.customCheckBox1.Name = "customCheckBox1";
            this.customCheckBox1.Size = new System.Drawing.Size(989, 66);
            this.customCheckBox1.TabIndex = 2;
            this.customCheckBox1.Text = "customCheckBox1";
            // 
            // HistoryBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customCheckBox1);
            this.Name = "HistoryBoxControl";
            this.Size = new System.Drawing.Size(1066, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomCheckBox customCheckBox1;
    }
}
