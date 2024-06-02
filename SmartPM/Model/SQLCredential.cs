using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Model
{
    public class SQLCredential : CredentialBase
    {
        public int DBType { get; set; }
        public string DBServerName { get; set; }
        public string DBUsername { get; set; }
        public string DBPassword { get; set; }
      
    }
}
