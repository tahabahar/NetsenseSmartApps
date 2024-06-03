using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM
{
    public enum CredentialTypeEnum
    {
        //Note hepsinde olacak.
        //MFAType hepsinde olsun

        Web = 1, // WebURL, Username, Passwork        
        Email = 2, // Emailaccount, Password, 
        Computer = 3, //Domain, Username, Password, Pin
        Database = 4, // Server Name, Username, Password

        App = 5,  //app name, username, pwd, 
        Bank = 6, //wesite, username, parola, password
        CreditCard =7, //CardName, Last4Digit, Pasword, CVC, ExpirationDate
        WifiNetwork =8,  //WifiName, Password        

        API = 9 // APIURL, SecretKey, Secret, 


    }

}
