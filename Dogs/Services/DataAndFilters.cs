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
        public void PopulateStackPanel(List<Breed> data,WrapPanel panel)
        {
            panel.Children.Clear();
            foreach (var item in data)
            {
                panel.Children.Add(new ShowDataConsumable(item));
            }
        }
    }
}
