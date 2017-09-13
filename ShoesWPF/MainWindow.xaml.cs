using ShoesWPF.Factories;
using ShoesWPF.ShopService;
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


namespace ShoesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShoesContractClient client = new ShoesContractClient();
        public MainWindow()
        {
            InitializeComponent();
            Factories.ItemsSource = client.getAllShoes();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //client.addFactory(new FactoryService() { Name = NewFacName.Text });
            //Factories.ItemsSource = client.getFactories();
        }
    }
}
