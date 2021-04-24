using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMRS.Config
{
    public class EnvironmentDetails
    {
        public string baseUrl { get; set; }
        public Browsers browser { get; set; }
        public TestEnvironments env = AppConfig.env;
        public string userName { get; set; }
        public string password { get; set; }
        public EnvironmentDetails()
        {
            switch (env)
            {
                case TestEnvironments.QA:
                    break;
                case TestEnvironments.STAGE:
                    break;
                case TestEnvironments.PROD:
                    baseUrl = ProdConfig.baseUrl;
                    browser = AppConfig.browser;
                    userName = ProdConfig.userName;
                    password = ProdConfig.password;
                    break;
                default:
                    baseUrl = ProdConfig.baseUrl;
                    browser = AppConfig.browser;
                    userName = ProdConfig.userName;
                    password = ProdConfig.password;
                    break;
            }

        }
    }
}
