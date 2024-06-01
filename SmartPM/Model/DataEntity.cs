using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM
{
    public class DataEntity
    {
        public string Name { get; set; }
        public string UsernameOrEmail { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }
        public string ValidThru { get; set; }
        public string Url { get; set; }
        public TypeEnum Type { get; set; }
        public int Id { get; set; }
        public int No { get; set; }
        public int CVV { get; set; }
        public MfaEnum MFA { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
