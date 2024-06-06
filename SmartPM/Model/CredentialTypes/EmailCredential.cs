using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Model.CredentialTypes
{
    public class EmailCredential
    {
        public string EmailAccount { get; set; }
        public string Password { get; set; }
        public string RecoveryEmail { get; set; }
    }
}
