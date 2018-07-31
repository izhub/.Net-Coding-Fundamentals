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

namespace _21_WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// WPF - Windows Presentation Foundation 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyOtherClick;    //wired manually 

        }

        private void button_MyOtherClick(object sender, RoutedEventArgs e)
        {
            myOtherLabel.Content = "Hello again!";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello world";
        }
    }
}
