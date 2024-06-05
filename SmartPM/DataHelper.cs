using Newtonsoft.Json;
using SmartPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SmartPM
{
    public static class DataHelper
    {
        public static BindingList<CredentialEntry> MyData = new BindingList<CredentialEntry>();

        public static string FileName = Path.Combine(Application.StartupPath, "credentialdata.json");

        public static AESCipher aesCipher;

        public static bool TryLoadData()
        {
            string encData = File.ReadAllText(FileName);

            string data = aesCipher.Decrypt(encData);

            if (data == null)
            {
                return false;
            }
            else
            {
                MyData = JsonConvert.DeserializeObject<BindingList<CredentialEntry>>(data);
                return true;
            }
        }


        public static void SaveData()
        {
            string data = JsonConvert.SerializeObject(MyData);

            string encData = aesCipher.Encrypt(data);

            File.WriteAllText(FileName, encData);
        }


        public static void AddOrUpdate(CredentialEntry credentialEntry)
        {

            //eklenen kayıt listede varsa onu bul ve sil
            foreach (CredentialEntry entry in MyData)
            {
                if (credentialEntry.Id == entry.Id)
                {
                   MyData.Remove(entry);
                    break;
                }
            }

            //listeye yeni kaydı ekle.
            MyData.Add(credentialEntry);


            SaveData();
        }

    }
}
