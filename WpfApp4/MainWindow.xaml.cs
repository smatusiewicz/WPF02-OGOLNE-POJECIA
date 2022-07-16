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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Counter = 0;

            /* 
             * Button a = new Button();
             a.Content = "Test";
             siatka.Children.Add(a);
            */
        }
        /*
       * private void add_Click(object sender, RoutedEventArgs e)
       {
           label_content.Content = Counter++;
       }
      */
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //test.Text = "przetestowane";
            MessageBox.Show("TEST");
        }
    }
}
