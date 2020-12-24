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
using System.ComponentModel.DataAnnotations;
using DataAccess.Models;

namespace YoutubeProject
{
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private async void signUp_Click(object sender, EventArgs e)
        {
            exceptionLabel.Text = string.Empty;
            userValidationObjectBindingSource.EndEdit();
            UserValidationObject currentUser = userValidationObjectBindingSource.Current as UserValidationObject;
            if (currentUser != null)
            {
                ValidationContext context = new ValidationContext(currentUser, null, null);
                IList<ValidationResult> errors = new List<ValidationResult>();
                if (!Validator.TryValidateObject(currentUser, context, errors, true))
                {
                    foreach (ValidationResult error in errors)
                        exceptionLabel.Text += error.ErrorMessage + "\n";
                    return;
                }
            }

            var userManager = Program.ServiceProvider.GetService<IUserManager>();
            using (userManager)
            {
                var userResult = await userManager.TrySignUpAsync(new BusinessLogic.Models.CreateUserDto()
                {
                    FirstName = firstName.Text,
                    SecondName = secondName.Text,
                    Email = email.Text,
                    MotherTown = motherTown.Text,
                    BirthDate = (DateTime)birthDate.ValidateText(),
                    Password = password.Text
                });
                if (userResult.User != null)
                {
                    using (UserForm userForm = new UserForm(userResult.User))
                    {
                        this.ParentForm.Hide();
                        userForm.Show();
                    }
                }
                else if (userResult.Exception != null)
                {
                    exceptionLabel.Text = userResult.Exception.Message;
                }
            }
        }

        private void RegistrationControl_Load(object sender, EventArgs e)
        {
            userValidationObjectBindingSource.DataSource = new UserValidationObject();
        }

    }
}
