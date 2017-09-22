using ShoesWPF.ServiceReference;
using ShoesWPF.ServiceReferenceHome;
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

namespace ShoesWPF.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {       
        public Window1()
        {
            InitializeComponent();               
           
            ShoesGrid.ItemsSource = ShoesDataBaseConnection.Shoes.getAllShoes();
            FactoriesFilter.ItemsSource = ShoesDataBaseConnection.Factory.getFactories();
            SizeFilter.ItemsSource = ShoesDataBaseConnection.Sizes.GetSizes();
            AgeFilter.ItemsSource = ShoesDataBaseConnection.AgeStatus.GetGetAgeStatus();
            GenderFilter.ItemsSource = ShoesDataBaseConnection.GenderStatus.GetGender();
        }

        private void ResetFiltersButton_Click(object sender, RoutedEventArgs e)
        {
            FactoriesFilter.ItemsSource = ShoesDataBaseConnection.Factory.getFactories();
            SizeFilter.ItemsSource = ShoesDataBaseConnection.Sizes.GetSizes();
            AgeFilter.ItemsSource = ShoesDataBaseConnection.AgeStatus.GetGetAgeStatus();
            GenderFilter.ItemsSource = ShoesDataBaseConnection.GenderStatus.GetGender();
        }

        private void SizeFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }
    }
}
