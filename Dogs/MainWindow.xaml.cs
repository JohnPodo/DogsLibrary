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
using DogApi;
using Dogs.ReusableContent;
using Dogs.Services;

namespace Dogs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Breed> data;
        List<Breed> filteredData;
        DataAndFilters service;
        public MainWindow()
        {
            InitializeComponent();
            service = new DataAndFilters();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            data = API.GetData();
            filteredData = data;
            service.PopulatePanel(filteredData, Dock);
            service.PopulateSearchField(filteredData, SearchNameBox);
        }

        private void searchNamebtn_Click(object sender, RoutedEventArgs e)
        {
            service.FilterDataByName(filteredData, SearchNameBox.Text, Dock);


        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            filteredData = data;
            SearchNameBox.Text = "";
            service.PopulatePanel(filteredData, Dock);
        }
    }
}
