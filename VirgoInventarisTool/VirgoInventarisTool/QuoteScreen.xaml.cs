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
    /// Interaction logic for QuoteScreen.xaml
    /// </summary>
    public partial class QuoteScreen : Window
    {
        public QuoteScreen()
        {
            InitializeComponent();
        }

        private void QuoteScreen_Back_Click(object sender, RoutedEventArgs e)
        {
            orderScreen os = new orderScreen();
            os.Show();
            this.Close();
        }
    }
}
