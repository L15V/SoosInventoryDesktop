﻿using System;
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
        private TextBox TBcola, TBcolaZero, TBsprite, TBfuzeGreen, TBfuzeSparkling, TBfuzeBlack, TBfanta, TBcassis, TBo2Geel, TBo2Rood, TBo2Groen, TBredbull, TBfristi, TBchocomel, TBspaRood;
        private TextBox TBhj, TBjupiler, TBliefmans, TBleffeBlond, TBpalm, TBhoegaarde, TBwitteWijn, TBrodeWijn, TBbacardi, TBbacardiR;

        public QuoteScreen()
        {
            InitializeComponent();

            TBcola = (TextBox)qCola;
            TBcolaZero = (TextBox)qColaZ;
            TBsprite = (TextBox)qSprite;
            TBfuzeGreen = (TextBox)qFuzeG;
            TBfuzeSparkling = (TextBox)qFuzeS;
            TBfuzeBlack = (TextBox)qFuzeB;
            TBfanta = (TextBox)qFanta;
            TBcassis = (TextBox)qCassis;
            TBo2Geel = (TextBox)qO2Ge;
            TBo2Rood = (TextBox)qO2R;
            TBo2Groen = (TextBox)qO2Gr;
            TBredbull = (TextBox)qRedbull;
            TBfristi = (TextBox)qFristi;
            TBchocomel = (TextBox)qChocomel;
            TBspaRood = (TextBox)qSpaR;

            TBhj = (TextBox)qHertogJan;
            TBjupiler = (TextBox)qJupiler;
            TBliefmans = (TextBox)qLiefmans;
            TBleffeBlond = (TextBox)qLeffeB;
            TBpalm = (TextBox)qPalm;
            TBhoegaarde = (TextBox)qHoegaarde;
            TBwitteWijn = (TextBox)qWijnW;
            TBrodeWijn = (TextBox)qWijnR;
            TBbacardi = (TextBox)qBacardi;
            TBbacardiR = (TextBox)qBacardiR;

            TBcola.Text = Properties.DrinkQuotums.Default.Cola.ToString();
            TBcolaZero.Text = Properties.DrinkQuotums.Default.ColaZero.ToString();
            TBsprite.Text = Properties.DrinkQuotums.Default.Sprite.ToString();
            TBfuzeGreen.Text = Properties.DrinkQuotums.Default.FuzeGreen.ToString();
            TBfuzeSparkling.Text = Properties.DrinkQuotums.Default.FuzeSparkling.ToString();
            TBfuzeBlack.Text = Properties.DrinkQuotums.Default.FuzeBlacktea.ToString();
            TBfanta.Text = Properties.DrinkQuotums.Default.Fanta.ToString();
            TBcassis.Text = Properties.DrinkQuotums.Default.Cassis.ToString();
            TBo2Geel.Text = Properties.DrinkQuotums.Default.o2Geel.ToString();
            TBo2Rood.Text = Properties.DrinkQuotums.Default.o2Rood.ToString();
            TBo2Groen.Text = Properties.DrinkQuotums.Default.o2Groen.ToString();
            TBredbull.Text = Properties.DrinkQuotums.Default.Redbull.ToString();
            TBfristi.Text = Properties.DrinkQuotums.Default.Fristi.ToString();
            TBchocomel.Text = Properties.DrinkQuotums.Default.Chocomel.ToString();
            TBspaRood.Text = Properties.DrinkQuotums.Default.SpaRood.ToString();

            TBhj.Text = Properties.DrinkQuotums.Default.HertogJan.ToString();
            TBjupiler.Text = Properties.DrinkQuotums.Default.Jupiler.ToString();
            TBliefmans.Text = Properties.DrinkQuotums.Default.Liefmans.ToString();
            TBleffeBlond.Text = Properties.DrinkQuotums.Default.LeffeBlond.ToString();
            TBpalm.Text = Properties.DrinkQuotums.Default.Palm.ToString();
            TBhoegaarde.Text = Properties.DrinkQuotums.Default.Hoegaarde.ToString();
            TBwitteWijn.Text = Properties.DrinkQuotums.Default.WitteWijn.ToString();
            TBrodeWijn.Text = Properties.DrinkQuotums.Default.RodeWijn.ToString();
            TBbacardi.Text = Properties.DrinkQuotums.Default.Bacardi.ToString();
            TBbacardiR.Text = Properties.DrinkQuotums.Default.BacardiRazz.ToString();
        }

        private void QuoteScreen_Back_Click(object sender, RoutedEventArgs e)
        {
            orderScreen os = new orderScreen();
            os.Show();
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Properties.DrinkQuotums.Default.Cola = Convert.ToInt32(TBcola.Text);
            Properties.DrinkQuotums.Default.ColaZero = Convert.ToInt32(TBcolaZero.Text);
            Properties.DrinkQuotums.Default.Sprite = Convert.ToInt32(TBsprite.Text);
            Properties.DrinkQuotums.Default.FuzeGreen = Convert.ToInt32(TBfuzeGreen.Text);
            Properties.DrinkQuotums.Default.FuzeSparkling = Convert.ToInt32(TBfuzeSparkling.Text);
            Properties.DrinkQuotums.Default.FuzeBlacktea = Convert.ToInt32(TBfuzeBlack.Text);
            Properties.DrinkQuotums.Default.Fanta = Convert.ToInt32(TBfanta.Text);
            Properties.DrinkQuotums.Default.Cassis = Convert.ToInt32(TBcassis.Text);
            Properties.DrinkQuotums.Default.o2Geel = Convert.ToInt32(TBo2Geel.Text);
            Properties.DrinkQuotums.Default.o2Rood = Convert.ToInt32(TBo2Rood.Text);
            Properties.DrinkQuotums.Default.o2Groen = Convert.ToInt32(TBo2Groen.Text);
            Properties.DrinkQuotums.Default.Redbull = Convert.ToInt32(TBredbull.Text);
            Properties.DrinkQuotums.Default.Fristi = Convert.ToInt32(TBfristi.Text);
            Properties.DrinkQuotums.Default.Chocomel = Convert.ToInt32(TBchocomel.Text);
            Properties.DrinkQuotums.Default.SpaRood = Convert.ToInt32(TBspaRood.Text);

            Properties.DrinkQuotums.Default.HertogJan = Convert.ToInt32(TBhj.Text);
            Properties.DrinkQuotums.Default.Jupiler = Convert.ToInt32(TBjupiler.Text);
            Properties.DrinkQuotums.Default.Liefmans = Convert.ToInt32(TBliefmans.Text);
            Properties.DrinkQuotums.Default.LeffeBlond = Convert.ToInt32(TBleffeBlond.Text);
            Properties.DrinkQuotums.Default.Palm = Convert.ToInt32(TBpalm.Text);
            Properties.DrinkQuotums.Default.Hoegaarde = Convert.ToInt32(TBhoegaarde.Text);
            Properties.DrinkQuotums.Default.WitteWijn = Convert.ToInt32(TBwitteWijn.Text);
            Properties.DrinkQuotums.Default.RodeWijn = Convert.ToInt32(TBrodeWijn.Text);
            Properties.DrinkQuotums.Default.Bacardi = Convert.ToInt32(TBbacardi.Text);
            Properties.DrinkQuotums.Default.BacardiRazz = Convert.ToInt32(TBbacardiR.Text);

            Properties.DrinkQuotums.Default.Save();
            Properties.DrinkQuotums.Default.Upgrade();
        }

        private void OverviewButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
