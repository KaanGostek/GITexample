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
using System.Text.RegularExpressions;

namespace GITexample
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            if (regex.IsMatch(e.Text))
            {
                Console.WriteLine("yupers");
                e.Handled = regex.IsMatch(e.Text);
            }
        }

        private void doCalc(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("got in");
            Int32.TryParse(textbox1.Text, out int first);
            Console.WriteLine("first: " + first);
            Int32.TryParse(textbox2.Text, out int second);
            Console.WriteLine("second: " + second);
            labelAnswer.Content = first + second;
        }
    }
}
