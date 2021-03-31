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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dog.Models;

namespace Dogs.ReusableContent
{
    /// <summary>
    /// Interaction logic for ShowDataConsumable.xaml
    /// </summary>
    public partial class ShowDataConsumable : UserControl
    {
        private Breed _breed;
        public ShowDataConsumable(Breed breed)
        {
            InitializeComponent();
            _breed = breed;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PictureBox.Source = new BitmapImage(new Uri($"{_breed.image.url}"));
            BreedName.Text = _breed.name;
            Bred.Text = _breed.bred_for;
            Origin.Text = _breed.origin;
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            BreedDetails details = new BreedDetails(_breed);
            details.ShowDialog();
        }
    }
}
