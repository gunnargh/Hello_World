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

namespace PrettyHairUI
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            ProductType p = new ProductType(1, "hello", 12, 5);

            ProductType p1 = new ProductType(2, "hello11", 121, 15);
            ProductTypeRepository ptr = new ProductTypeRepository();
            foreach (ProductType pe in ptr.load())
            {
                ptr.Add(pe);
            }

            dataGrid.DataContext = ptr;
        }
    }
}
