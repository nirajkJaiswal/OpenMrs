using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenMRS.Config
{
   public static class AppConfig
    {
        public static TestEnvironments env = TestEnvironments.PROD;
        public static Browsers browser = Browsers.CHROME;
    }
}
