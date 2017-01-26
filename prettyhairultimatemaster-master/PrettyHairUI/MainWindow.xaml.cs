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
using PrettyHairLibrary;
using System.Collections.ObjectModel;

namespace PrettyHairUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<ProductType> prod = new ObservableCollection<ProductType>();

        public ObservableCollection<Customer> cust = new ObservableCollection<Customer>();
        Controller ctrl = new Controller();

        public MainWindow()
        {
            InitializeComponent();
            ctrl.InitializeRepositories();
            
            
        }

        private void TabItem_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (KeyValuePair<int, ProductType> p in ctrl.GetProductList())
            {
                prod.Add(p.Value);
            }
            lstNames.ItemsSource = prod;
        }

        private void TabItem_Loaded_1(object sender, RoutedEventArgs e)
        {
            foreach (KeyValuePair<int, Customer> p in ctrl.GetcustomerList())
            {
                cust.Add(p.Value);
            }
            lstNamesCustomers.ItemsSource = cust;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Customer cust = (Customer)lstNames.SelectedItem;
            
        }
    }
}
