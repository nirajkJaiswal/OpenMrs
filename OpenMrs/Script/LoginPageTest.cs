using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenMRS.Pages;

namespace OpenMRS.Script
{
    [TestFixture]
    public class LoginPageTest : OpenMrsApp
    {
        [Test]
        public void ValidateLogin()
        {
            Console.WriteLine("Hello");
            loginPage.Login();
        }
    }
}
