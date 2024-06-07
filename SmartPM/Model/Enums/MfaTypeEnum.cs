using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Model
{

    public enum MFATypeEnum
    {
        None = 1,
        GoogleAuthenticator = 2,
        MicrosoftAuthenticator = 3,
        Defender = 4,
        Sms = 5,
        Mail = 6
    }

}
