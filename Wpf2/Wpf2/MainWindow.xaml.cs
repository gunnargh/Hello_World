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

namespace Wpf2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Controler controler;
        Repository pe;
        public MainWindow()
        {
            controler = Controler.GetInstance();
            Repository pe = new Repository();
            InitializeComponent();
            counter.Content = controler.PerconCount;
            counter2.Content = controler.PersonIndex;
        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        { 
            Person p = new Person();
            p.Age =  Convert.ToInt32(textBox3.Text);
            p.FirstName = textBox1.Text;
            p.LastName = textBox2.Text;
            p.TelephoneNr = textBox4.Text;
            controler.NewPerson(p);
            cleartxtbox();
            updatecounter();

        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            controler.DeletePerson();
            controler.NextPerson();
            updatecounter();
        }

        private void buttonUp_Click(object sender, RoutedEventArgs e)
        {
            controler.NextPerson();
            currentPer();
            updatecounter();
        }

        private void buttonDown_Click(object sender, RoutedEventArgs e)
        {
            controler.PrevPerson();
            currentPer();
            updatecounter();
        }
        private void currentPer()
        {
            textBox1.Text = controler.CurentPerson.FirstName;
            textBox2.Text = controler.CurentPerson.LastName;
            textBox3.Text = controler.CurentPerson.Age.ToString();
            textBox4.Text = controler.CurentPerson.TelephoneNr;
        }
        private void updatecounter()
        {
            counter.Content = controler.PerconCount;
            counter2.Content = controler.PersonIndex;
        }
        private void cleartxtbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
