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

namespace Cafeteria_Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFood_Click()
        {

        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/HomePage.xaml", UriKind.Relative));
        }

        private void BtnAdd_Inventory_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/AddInventoryPage.xaml", UriKind.Relative));
        }

        private void BtnManage_Inventory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSales_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/SalesPage.xaml", UriKind.Relative));

        }

        private void BtnAdd_Stuff_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/AddStuffPage.xaml", UriKind.Relative));
        }

        private void BtnManage_Stuff_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/ManageStuffPage.xaml", UriKind.Relative));
        }

        private void BtnAdmin_Area_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAbout_Us_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/AboutUsPage.xaml", UriKind.Relative));
        }

        private void BtnContact_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Uri("View/ContactPage.xaml", UriKind.Relative));
        }
    }
}
