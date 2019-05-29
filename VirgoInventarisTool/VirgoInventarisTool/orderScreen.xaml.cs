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
using System.Windows.Shapes;

namespace VirgoInventarisTool
{
    /// <summary>
    /// Interaction logic for orderScreen.xaml
    /// </summary>
    public partial class orderScreen : Window
    {
        public orderScreen()
        {
            InitializeComponent();
        }

        private void OrderScreen_Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void OrderScreen_Quotems_Click(object sender, RoutedEventArgs e)
        {
            QuoteScreen qs = new QuoteScreen();
            qs.Show();
            this.Close();
        }
    }
}
