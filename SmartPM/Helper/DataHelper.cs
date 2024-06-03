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
        public static List<CredentialEntry> GetData()
        {
            string stringdata = File.ReadAllText("c:\\jsondenemes\\credentialdata.json");

            List<CredentialEntry> result = JsonConvert.DeserializeObject<List<CredentialEntry>>(stringdata);

            return result;
        }
    }
}
