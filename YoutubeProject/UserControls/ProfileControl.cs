using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Contexts;
using DataAccess.Models;

namespace YoutubeProject
{
    public partial class ProfileControl : UserControl
    {
        User user1 = new User();
        public ProfileControl()
        {
            InitializeComponent();

        }

        private void CreateEvents()
        {

        }

        private void OnEditFirstNameClick()
        {
            firstName.ReadOnly = false;
        }
        private void OnEditSecondNameClick()
        {
            firstName.ReadOnly = false;
        }
        private void OnEditEmailClick()
        {
            firstName.ReadOnly = false;
        }

        private async void signUpButton_Click(object sender, EventArgs e)
        {
            UserContext userContext = new UserContext();

            User user = userContext.Users.FirstOrDefault(x => x.UserId == user1.UserId);
            user.Email = email.Text;
            user.FirstName = firstName.Text;
            user.SecondName = secondName.Text;
            user.MotherTown = motherTown.Text;
            user.BirthDate = (DateTime)birthDate.ValidateText();
            user.Password = password.Text;

            await userContext.SaveChangesAsync();
        }
    }
}
