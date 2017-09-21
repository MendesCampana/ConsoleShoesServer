using ShoesWPF.ServiceReference;
using ShoesWPF.View;
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
        private Window1 _goodsWindow = new Window1();
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            _goodsWindow.ShowDialog();
            this.Show();
            //if (ClientConnection.Client.CheckLogin(loginText.Text, passText.Password))
            //{
            //    this.Hide();
            //    _goodsWindow.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Denied");
            //}
        }
    }
}
