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
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Category { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public DateTime ValidThru { get; set; }
        public PriorityEnum Priority { get; set; }
        public CredentialTypeEnum CredentialType { get; set; }
        public string CredentialJsonData { get; set; }
        public MFATypeEnum MFAType { get; set; }


    }
}
