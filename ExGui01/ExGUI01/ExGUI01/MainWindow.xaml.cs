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

namespace ExGUI01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            int i = 0;
            InitializeComponent();

        }

        private void button_scrolldown_Click(object sender, RoutedEventArgs e)
        {
            string txt1 = textBox1.Text;
            string txt2 = textBox2.Text;
            string txt3 = textBox3.Text;
            string txt4 = textBox4.Text;

            textBox1.Text = txt4;
            textBox2.Text = txt1;
            textBox3.Text = txt2;
            textBox4.Text = txt3;
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button_scrollup_Click(object sender, RoutedEventArgs e)
        {
            string txt1 = textBox1.Text;
            string txt2 = textBox2.Text;
            string txt3 = textBox3.Text;
            string txt4 = textBox4.Text;

            textBox1.Text = txt2;
            textBox2.Text = txt3;
            textBox3.Text = txt4;
            textBox4.Text = txt1;
        }
    }
}
