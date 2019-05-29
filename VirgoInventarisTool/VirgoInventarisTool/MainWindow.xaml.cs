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

namespace VirgoInventarisTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private JsonApiHandler jsonApiHandler;
        public MainWindow()
        {
            InitializeComponent();
            jsonApiHandler = new JsonApiHandler();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Console.WriteLine(jsonApiHandler.getLatestColdDrinks("http://192.168.1.143:8080"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            jsonApiHandler.GetToken("http://192.168.1.143:8080" , true);
        }
    }
}
