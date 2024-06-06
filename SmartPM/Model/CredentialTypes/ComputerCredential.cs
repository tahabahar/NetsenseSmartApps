using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Model.CredentialTypes
{
    public class ComputerCredential
    {
        public string Domain { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Pin { get; set; }
    }
}
