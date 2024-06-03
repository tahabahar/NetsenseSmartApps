using DevExpress.XtraLayout.Customization;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM
{
    public class CredentialEntry
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime ValidThru { get; set; }
        public string Priority { get; set; }
        public CredentialTypeEnum CredentialType { get; set; }
        public CredentialBase Credential { get; set; }

        public WebCredential WebCredential { get; set; }
        public SQLCredential SQLCredential { get; set; }


    }
}
