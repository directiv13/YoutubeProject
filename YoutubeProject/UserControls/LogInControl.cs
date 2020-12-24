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
    public partial class LogInControl : UserControl
    {
        public LogInControl()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void login_Changed(object sender, EventArgs e)
        {

        }

        private async void logIn_Click(object sender, EventArgs e)
        {
            using (var userManager = Program.ServiceProvider.GetService<IUserManager>())
            {
                var userResult = await userManager.TryLoginAsync(new BusinessLogic.Models.LoginUserDto()
                {
                    Email = email.Text,
                    Password = password.Text
                });
                if (userResult.User != null)
                {
                    UserForm userForm = new UserForm(userResult.User);
                    this.ParentForm.Hide();
                    userForm.Show();
                }
                else if (userResult.Exception != null)
                {
                    label1.Text = userResult.Exception.Message;
                }
            }
        }
    }
}
