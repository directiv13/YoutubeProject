namespace YoutubeProject
{
    partial class RegistrationControl
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.motherTownLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.email = new YoutubeProject.PlaceHolderTextBox();
            this.userValidationObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firstName = new YoutubeProject.PlaceHolderTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.motherTown = new YoutubeProject.PlaceHolderTextBox();
            this.birthDate = new YoutubeProject.DateBoxControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.password = new YoutubeProject.PlaceHolderTextBox();
            this.secondName = new YoutubeProject.PlaceHolderTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.exceptionLabel = new System.Windows.Forms.Label();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userValidationObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(552, 132);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(177, 39);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(633, 267);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(103, 39);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // motherTownLabel
            // 
            this.motherTownLabel.AutoSize = true;
            this.motherTownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motherTownLabel.Location = new System.Drawing.Point(533, 334);
            this.motherTownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.motherTownLabel.Name = "motherTownLabel";
            this.motherTownLabel.Size = new System.Drawing.Size(194, 39);
            this.motherTownLabel.TabIndex = 3;
            this.motherTownLabel.Text = "Mothertown";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(568, 402);
            this.birthDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(162, 39);
            this.birthDateLabel.TabIndex = 4;
            this.birthDateLabel.Text = "Birth date";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(563, 470);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(167, 39);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(659, 617);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(389, 96);
            this.signUpButton.TabIndex = 7;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.motherTown);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.birthDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.secondName);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(773, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(401, 380);
            this.panel1.TabIndex = 13;
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
            this.email.Size = new System.Drawing.Size(388, 42);
            this.email.TabIndex = 3;
            // 
            // userValidationObjectBindingSource
            // 
            this.userValidationObjectBindingSource.DataSource = typeof(YoutubeProject.UserValidationObject);
            // 
            // firstName
            // 
            this.firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "FirstName", true));
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.firstName.Location = new System.Drawing.Point(12, 0);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.PlaceHolderText = null;
            this.firstName.Size = new System.Drawing.Size(388, 42);
            this.firstName.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.panel5.Location = new System.Drawing.Point(0, 206);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 42);
            this.panel5.TabIndex = 28;
            // 
            // motherTown
            // 
            this.motherTown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.motherTown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.motherTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "MotherTown", true));
            this.motherTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.motherTown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.motherTown.Location = new System.Drawing.Point(13, 206);
            this.motherTown.Multiline = true;
            this.motherTown.Name = "motherTown";
            this.motherTown.PlaceHolderText = null;
            this.motherTown.Size = new System.Drawing.Size(388, 42);
            this.motherTown.TabIndex = 4;
            // 
            // birthDate
            // 
            this.birthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.birthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.birthDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "BirthDate", true));
            this.birthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F);
            this.birthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.birthDate.Location = new System.Drawing.Point(0, 274);
            this.birthDate.Mask = "00/00/0000";
            this.birthDate.Name = "birthDate";
            this.birthDate.PlaceHolderText = null;
            this.birthDate.Size = new System.Drawing.Size(400, 42);
            this.birthDate.TabIndex = 5;
            this.birthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthDate.ValidatingType = typeof(System.DateTime);
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
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "Password", true));
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.password.Location = new System.Drawing.Point(13, 338);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceHolderText = null;
            this.password.Size = new System.Drawing.Size(388, 42);
            this.password.TabIndex = 6;
            // 
            // secondName
            // 
            this.secondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(197)))), ((int)(((byte)(209)))));
            this.secondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userValidationObjectBindingSource, "SecondName", true));
            this.secondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.secondName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.secondName.Location = new System.Drawing.Point(13, 66);
            this.secondName.Multiline = true;
            this.secondName.Name = "secondName";
            this.secondName.PlaceHolderText = null;
            this.secondName.Size = new System.Drawing.Size(388, 42);
            this.secondName.TabIndex = 2;
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
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(DataAccess.Models.User);
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
            // exceptionLabel
            // 
            this.exceptionLabel.AutoSize = true;
            this.exceptionLabel.ForeColor = System.Drawing.Color.Red;
            this.exceptionLabel.Location = new System.Drawing.Point(807, 7);
            this.exceptionLabel.Name = "exceptionLabel";
            this.exceptionLabel.Size = new System.Drawing.Size(0, 17);
            this.exceptionLabel.TabIndex = 15;
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameLabel.Location = new System.Drawing.Point(501, 199);
            this.secondNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(227, 39);
            this.secondNameLabel.TabIndex = 1;
            this.secondNameLabel.Text = "Second name";
            // 
            // RegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.exceptionLabel);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.motherTownLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.secondNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationControl";
            this.Size = new System.Drawing.Size(1707, 748);
            this.Tag = "";
            this.Load += new System.EventHandler(this.RegistrationControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userValidationObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label motherTownLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exceptionLabel;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.BindingSource userValidationObjectBindingSource;
        private DateBoxControl birthDate;
        private PlaceHolderTextBox email;
        private PlaceHolderTextBox firstName;
        private PlaceHolderTextBox motherTown;
        private PlaceHolderTextBox password;
        private PlaceHolderTextBox secondName;
    }
}
