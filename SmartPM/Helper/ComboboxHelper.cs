using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPM.Helper
{
    public class ComboboxHelper
    {
        public List<string> categories = new List<string>();

        // Yeni kategori ekler ve var olup olmadığını kontrol eder
        public void AddCategory(string category)
        {
            if (!categories.Contains(category) && !string.IsNullOrEmpty(category))
            {
                categories.Add(category);
            }
        }

        // Tüm kategorileri döndürür
        public List<string> GetCategories()
        {
            return categories;
        }
    }
}
