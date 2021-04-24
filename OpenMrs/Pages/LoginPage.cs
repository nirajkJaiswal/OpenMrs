using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenMRS.Constant;
using OpenQA.Selenium.Support.UI;

namespace OpenMRS.Pages
{
    public class LoginPage : BasePage
    {
        protected IWebElement _UserName = driver.FindElement(By.Id("username"));
        protected IWebElement _Password = driver.FindElement(By.Id("password"));
        protected IWebElement _Login = driver.FindElement(By.Id("loginButton"));
        //Location List
        protected IWebElement _InpatientWard = driver.FindElement(By.Id("Inpatient Ward"));
        protected IWebElement _IsolationWard = driver.FindElement(By.Id("Isolation Ward"));
        protected IWebElement _Laboratory = driver.FindElement(By.Id("Laboratory"));
        protected IWebElement _OutpatientClinic = driver.FindElement(By.Id("Outpatient Clinic"));
        protected IWebElement _Pharmacy = driver.FindElement(By.Id("Pharmacy"));
        protected IWebElement _RegistraionDesk = driver.FindElement(By.Id("Registration Desk"));

        public void Login(string username=null, string password=null, Location location= Location.RegistrationDesk)
        {
            _UserName.SendKeys(username??EnvironmentDetails.userName);
            _Password.SendKeys(password?? EnvironmentDetails.password);
            SelectLocation(location);
            _Login.Click();
        }
        protected void SelectLocation(Location location)
        {
            switch (location)
            {
                case Location.InpatientWard:
                    _InpatientWard.Click();
                    break;
                case Location.IsolationWard:
                    _IsolationWard.Click();
                    break;
                case Location.Laboratory:
                    _Laboratory.Click();
                    break;
                case Location.OutpatientClinic:
                    _OutpatientClinic.Click();
                    break;
                case Location.Pharmacy:
                    _Pharmacy.Click();
                    break;
                case Location.RegistrationDesk:
                    _RegistraionDesk.Click();
                    break;
                default:
                    _RegistraionDesk.Click();
                    break;
            }
        }


    }
}
