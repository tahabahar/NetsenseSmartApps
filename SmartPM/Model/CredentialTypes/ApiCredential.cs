using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Model.CredentialTypes
{
    public class ApiCredential
    {
        public string ApiName { get; set; }
        public string ApiUsername { get; set; }
        public string ApiPassword { get; set; }
        public string AccessToken { get; set; }
        public string SecretKey { get; set; }
        public string ApiKey { get; set; }
        public string ApiUrl { get; set; }
    }
}
