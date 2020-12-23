namespace YoutubeProject
{
    partial class ProfileControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileControl));
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.motherTownLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.userValidationObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthDate = new YoutubeProject.DateBoxControl();
            this.email = new YoutubeProject.PlaceHolderTextBox();
            this.firstName = new YoutubeProject.PlaceHolderTextBox();
            this.motherTown = new YoutubeProject.PlaceHolderTextBox();
            this.password = new YoutubeProject.PlaceHolderTextBox();
            this.secondName = new YoutubeProject.PlaceHolderTextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userValidationObjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(544, 531);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(389, 96);
            this.signUpButton.TabIndex = 20;
            this.signUpButton.Text = "Done";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(448, 384);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(167, 39);
            this.passwordLabel.TabIndex = 19;
            this.passwordLabel.Text = "Password";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(453, 316);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(162, 39);
            this.birthDateLabel.TabIndex = 18;
            this.birthDateLabel.Text = "Birth date";
            // 
            // motherTownLabel
            // 
            this.motherTownLabel.AutoSize = true;
            this.motherTownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motherTownLabel.Location = new System.Drawing.Point(418, 248);
            this.motherTownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motherTownLabel.Name = "motherTownLabel";
            this.motherTownLabel.Size = new System.Drawing.Size(194, 39);
            this.motherTownLabel.TabIndex = 17;
            this.motherTownLabel.Text = "Mothertown";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(518, 181);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(103, 39);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Email";
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameLabel.Location = new System.Drawing.Point(386, 113);
            this.secondNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(227, 39);
            this.secondNameLabel.TabIndex = 15;
            this.secondNameLabel.Text = "Second name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(437, 46);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(177, 39);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.secondName);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(658, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(401, 380);
            this.panel1.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel5.Controls.Add(this.motherTown);
            this.panel5.Location = new System.Drawing.Point(0, 206);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(402, 42);
            this.panel5.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 42);
            this.panel2.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel6.Location = new System.Drawing.Point(0, 338);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 42);
            this.panel6.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 42);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel4.Controls.Add(this.email);
            this.panel4.Location = new System.Drawing.Point(0, 135);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 42);
            this.panel4.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1064, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 41);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1064, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 41);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(1064, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 41);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1064, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 41);
            this.button5.TabIndex = 26;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(1066, 323);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(38, 41);
            this.button6.TabIndex = 27;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(1064, 385);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(38, 41);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // userValidationObjectBindingSource
            // 
            this.userValidationObjectBindingSource.DataSource = typeof(YoutubeProject.UserValidationObject);
            // 
            // birthDate
            // 
            this.birthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.birthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "BirthDate", true));
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.birthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.birthDate.Location = new System.Drawing.Point(0, 270);
            this.birthDate.Mask = "00/00/0000";
            this.birthDate.Name = "birthDate";
            this.birthDate.PlaceHolderText = null;
            this.birthDate.ReadOnly = true;
            this.birthDate.Size = new System.Drawing.Size(401, 42);
            this.birthDate.TabIndex = 30;
            this.birthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthDate.ValidatingType = typeof(System.DateTime);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "Email", true));
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.email.Location = new System.Drawing.Point(13, 0);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.PlaceHolderText = null;
            this.email.ReadOnly = true;
            this.email.Size = new System.Drawing.Size(388, 42);
            this.email.TabIndex = 32;
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "FirstName", true));
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.firstName.Location = new System.Drawing.Point(14, 0);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.PlaceHolderText = null;
            this.firstName.ReadOnly = true;
            this.firstName.Size = new System.Drawing.Size(388, 42);
            this.firstName.TabIndex = 34;
            // 
            // motherTown
            // 
            this.motherTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.motherTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motherTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "MotherTown", true));
            this.motherTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.motherTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.motherTown.Location = new System.Drawing.Point(14, 0);
            this.motherTown.Multiline = true;
            this.motherTown.Name = "motherTown";
            this.motherTown.PlaceHolderText = null;
            this.motherTown.ReadOnly = true;
            this.motherTown.Size = new System.Drawing.Size(388, 42);
            this.motherTown.TabIndex = 36;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "Password", true));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.password.Location = new System.Drawing.Point(14, 338);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PlaceHolderText = null;
            this.password.ReadOnly = true;
            this.password.Size = new System.Drawing.Size(388, 42);
            this.password.TabIndex = 38;
            // 
            // secondName
            // 
            this.secondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.secondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "SecondName", true));
            this.secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.secondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.secondName.Location = new System.Drawing.Point(14, 66);
            this.secondName.Multiline = true;
            this.secondName.Name = "secondName";
            this.secondName.PlaceHolderText = null;
            this.secondName.ReadOnly = true;
            this.secondName.Size = new System.Drawing.Size(388, 42);
            this.secondName.TabIndex = 40;
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.motherTownLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "ProfileControl";
            this.Size = new System.Drawing.Size(1444, 673);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userValidationObjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label motherTownLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private DateBoxControl birthDate;
        private System.Windows.Forms.BindingSource userValidationObjectBindingSource;
        private PlaceHolderTextBox motherTown;
        private PlaceHolderTextBox secondName;
        private PlaceHolderTextBox password;
        private PlaceHolderTextBox firstName;
        private PlaceHolderTextBox email;
    }
}
