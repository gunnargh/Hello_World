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

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PrettyHairUI.EJL72_DBDataSet eJL72_DBDataSet = ((PrettyHairUI.EJL72_DBDataSet)(this.FindResource("eJL72_DBDataSet")));
            // Load data into the table Color. You can modify this code as needed.
            PrettyHairUI.EJL72_DBDataSetTableAdapters.ColorTableAdapter eJL72_DBDataSetColorTableAdapter = new PrettyHairUI.EJL72_DBDataSetTableAdapters.ColorTableAdapter();
            eJL72_DBDataSetColorTableAdapter.Fill(eJL72_DBDataSet.Color);
            System.Windows.Data.CollectionViewSource colorViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("colorViewSource")));
            colorViewSource.View.MoveCurrentToFirst();
            
        }
    }
}