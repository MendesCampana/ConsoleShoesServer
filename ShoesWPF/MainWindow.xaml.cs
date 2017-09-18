using ShoesWPF.ServiceReference;
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
        ShoesLoginContractClient client = new ShoesLoginContractClient();
        public MainWindow()
        {
            InitializeComponent();
            //Factories.ItemsSource = client.getAllShoes();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (client.CheckLogin(loginText.Text, passText.Password))
            {
                MessageBox.Show("succeded");
            }
            else
            {
                MessageBox.Show("Denied");
            }
        }
    }
}
