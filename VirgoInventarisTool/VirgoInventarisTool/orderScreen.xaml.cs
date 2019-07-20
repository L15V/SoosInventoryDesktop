using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

using Microsoft.Win32;

using NPOI.XSSF.UserModel;

namespace VirgoInventarisTool
{
    public partial class orderScreen : Window
    {
        private JsonApiHandler handler;
        private List<DrinkItem> coldDrinks, alcoholDrinks;

        List<int> qcoldDrink;
        List<int> qalcohol;

        public orderScreen()
        {
            InitializeComponent();
            handler = new JsonApiHandler();
            handler.GetToken("http://192.168.100.239:8080" , true);
            coldDrinks = handler.getLatestColdDrinks("http://192.168.100.239:8080");
            alcoholDrinks = handler.getLatestAlcoholDrinks("http://192.168.100.239:8080");

            qcoldDrink = new List<int>();
            qalcohol = new List<int>();

            qcoldDrink.Add(Properties.DrinkQuotums.Default.cola);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.cola_zero);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.sprite);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.fuze_green);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.fuze_sparkling);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.fuze_blacktea);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.fanta);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.cassis);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.o2_geel);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.o2_rood);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.o2_groen);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.redbull);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.fristi);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.chocomel);
            qcoldDrink.Add(Properties.DrinkQuotums.Default.spa_rood);

            qalcohol.Add(Properties.DrinkQuotums.Default.HertogJan);
            qalcohol.Add(Properties.DrinkQuotums.Default.Jupiler);
            qalcohol.Add(Properties.DrinkQuotums.Default.Liefmans);
            qalcohol.Add(Properties.DrinkQuotums.Default.LeffeBlond);
            qalcohol.Add(Properties.DrinkQuotums.Default.Palm);
            qalcohol.Add(Properties.DrinkQuotums.Default.Hoegaarde);
            qalcohol.Add(Properties.DrinkQuotums.Default.WitteWijn);
            qalcohol.Add(Properties.DrinkQuotums.Default.RodeWijn);
            qalcohol.Add(Properties.DrinkQuotums.Default.Bacardi);
            qalcohol.Add(Properties.DrinkQuotums.Default.BacardiRazz);
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

        private void OverzichtButton_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Inventaris_Overzicht";
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "Excel file (.xlsx) | *.xlsx";

            Nullable<bool> result = dlg.ShowDialog();

            if(result == true)
            {
                string filename = dlg.FileName;

                XSSFWorkbook wb;
                XSSFSheet coldSheet;
                XSSFSheet alcoholSheet;

                wb = new XSSFWorkbook();
                coldSheet = (XSSFSheet)wb.CreateSheet("fris");
                alcoholSheet = (XSSFSheet)wb.CreateSheet("alcohol");

                var r1c = coldSheet.CreateRow(0);
                r1c.CreateCell(0).SetCellValue("Export Datum:");
                r1c.CreateCell(1).SetCellValue(DateTime.Now.ToString("dd/MM/yyyy"));

                var r2c = coldSheet.CreateRow(1);
                r2c.CreateCell(0).SetCellValue("Drank");
                r2c.CreateCell(1).SetCellValue("Op vooraad");
                r2c.CreateCell(2).SetCellValue("Quotem");
                r2c.CreateCell(3).SetCellValue("Te bestellen");

                var r1a = alcoholSheet.CreateRow(0);
                r1a.CreateCell(0).SetCellValue("Export Datum:");
                r1a.CreateCell(1).SetCellValue(DateTime.Now.ToString("dd/MM/yyyy"));

                var r2a = alcoholSheet.CreateRow(1);
                r2a.CreateCell(0).SetCellValue("Drank");
                r2a.CreateCell(1).SetCellValue("Op vooraad");
                r2a.CreateCell(2).SetCellValue("Quotem");
                r2a.CreateCell(3).SetCellValue("Te bestellen");

                int count = 2;
                foreach (DrinkItem i in coldDrinks)
                {
                    int quote = qcoldDrink[count - 2];
                    var row = coldSheet.CreateRow(count);
                    row.CreateCell(0).SetCellValue(i.getName());
                    row.CreateCell(1).SetCellValue(i.getAmount());
                    row.CreateCell(2).SetCellValue(quote);
                    row.CreateCell(3).SetCellValue(quote - i.getAmount());

                    count = count + 1;
                }
                count = 2;
                foreach (DrinkItem i in alcoholDrinks)
                {
                    int quote = qalcohol[count - 2];
                    var row = alcoholSheet.CreateRow(count);
                    row.CreateCell(0).SetCellValue(i.getName());
                    row.CreateCell(1).SetCellValue(i.getAmount());
                    row.CreateCell(2).SetCellValue(quote);
                    row.CreateCell(3).SetCellValue(quote - i.getAmount());

                    count = count + 1;
                }

                for (int i = 0; i < 11; i++)
                {
                    coldSheet.AutoSizeColumn(i);
                    alcoholSheet.AutoSizeColumn(i);
                }

                using (var fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
                {
                    wb.Write(fs);
                }
            }
        }
    }
}
