using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace System.Configuration
{
    static class ConfigurationManager
    {
        public static Collections.Specialized.NameValueCollection AppSettings
        {
            get
            {
                var appSettings = new Collections.Specialized.NameValueCollection();
                appSettings.Add("AWSAccessKey", "AKIAJCSYZJNMJQFUHIHQ");
                appSettings.Add("AWSSecretKey", "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");
                appSettings.Add("ServiceURL", "dynamodb.us-west-2.amazonaws.com");
                appSettings.Add("AWSRegion", "us-west-2");
				appSettings.Add("AWSLogging", "None");
                return appSettings;
            }
        }
    }
}
