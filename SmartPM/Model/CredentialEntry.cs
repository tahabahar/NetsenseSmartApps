using DevExpress.XtraBars.Ribbon.ViewInfo;
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
        public string Note { get; set; }
        public string Description { get; set; }
        public CredentialTypeEnum CredentialType { get; set; }
        public string CredentialJsonData { get; set; }
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;

    }
}
