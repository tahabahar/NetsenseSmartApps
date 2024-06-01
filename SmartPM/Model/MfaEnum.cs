using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Model
{
    public class MfaEnum
    {
        public enum MFAEnum
        { 
            GoogleAuthenticator,
            MicrosoftAuthenticator,
            Defender,
            Sms,
            Mail
        }
    }
}
