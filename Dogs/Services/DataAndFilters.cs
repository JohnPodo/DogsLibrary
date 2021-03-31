using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Dog.Models;
using Dogs.ReusableContent;

namespace Dogs.Services
{
    class DataAndFilters
    {
        public void PopulatePanel(List<Breed> data,WrapPanel panel)
        {
            panel.Children.Clear();
            foreach (var item in data)
            {
                panel.Children.Add(new ShowDataConsumable(item));
            }
        }

        public void PopulateSearchField(List<Breed> data, ComboBox box)
        {
            var names = data.Select(s => s.name).ToList();
            foreach (var item in names)
            {
                box.Items.Add(item);
            }
        }

        public void FilterDataByName(List<Breed> data,string search, WrapPanel panel)
        {
            if (!string.IsNullOrEmpty(search))
            {
                data = data.Where(s => s.name.Contains(search)).ToList();
            }
            
            PopulatePanel(data, panel);
        }
    }
}
