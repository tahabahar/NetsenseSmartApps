using Newtonsoft.Json;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartPM
{
    public class DataHelper
    {
        public static BindingList<CredentialEntry> GetData()
        {
            string stringdata = File.ReadAllText("c:\\jsondenemes\\credentialdata.json");

            BindingList<CredentialEntry> result = JsonConvert.DeserializeObject<BindingList<CredentialEntry>>(stringdata);



            return result;
        }
    }
}
