using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BusinessLogic.Security;
using Microsoft.Extensions.DependencyInjection;
using YoutubeProject;

namespace BusinessLogic.Test
{
    [TestClass]
    public class UserManagerTest
    {
        [TestMethod]
        public void Login_NonExistentEmail_Test()
        {
            string inputEmail = "23@ffff";
            string inputPassword = "123123";

            LogInControl control = new LogInControl();
            control.
        }


    }
}