using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListApplication
{
    public class ApplicationSettings : ISettings
    {
        public string GetSetting(string key)
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                throw new ApplicationException(string.Format("The key could not be found: {0}", key));
            }
            return ConfigurationManager.AppSettings[key];
        }
    }
}
