using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Dog.Models;

namespace Dogs.ReusableContent
{
    /// <summary>
    /// Interaction logic for BreedDetails.xaml
    /// </summary>
    public partial class BreedDetails : Window
    {
        Breed dog;
        public BreedDetails(Breed data)
        {
            InitializeComponent();
            dog = data;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BreedName.Text = dog.name;
            Origin.Text = dog.origin;
            CodeCountry.Text = dog.country_code;
            Pic.Source= new BitmapImage(new Uri($"{dog.image.url}"));
            LifeSpan.Text = dog.life_span;
        }
    }
}
