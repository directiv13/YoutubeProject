using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using BusinessLogic.Security;

namespace YoutubeProject
{
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var userManager = Program.ServiceProvider.GetService<IUserManager>();
            using (userManager)
            {
                DateTime birthDate;// = DateTime.Parse(month.Text + "/" + day.Text + "/" + year.Text);
                if (DateTime.TryParse(month.Text + "/" + day.Text + "/" + year.Text, out birthDate))
                {
                    var user = await userManager.TrySignUpAsync(new BusinessLogic.Models.CreateUserDto()
                    {
                        FirstName = firstName.Text,
                        SecondName = secondName.Text,
                        Email = email.Text,
                        MotherTown = motherTown.Text,
                        BirthDate = birthDate,
                        Password = password.Text
                    });
                    if (user.User != null)
                    {
                        UserForm userForm = new UserForm();
                        this.ParentForm.Hide();
                        userForm.Show();
                    }
                    else if (user.Exception != null)
                    {
                        exceptionLabel.Text = user.Exception.Message;
                    }
                }
                else
                    exceptionLabel.Text = "The birth date should be entered in the format (dd:mm:yyyy).";
            }
        }

        private void email_Changed(object sender, KeyPressEventArgs e)
        {
            exceptionLabel.Text = string.Empty;
            if (!Validation.EmailValidator.GetInstance(email.Text).IsSatisfied())
                exceptionLabel.Text = "Incorrect format of email adress";
        }

    }
}
