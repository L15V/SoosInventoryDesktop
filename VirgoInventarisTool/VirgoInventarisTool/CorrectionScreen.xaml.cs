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
    /// Interaction logic for CorrectionScreen.xaml
    /// </summary>
    public partial class CorrectionScreen : Window
    {
        private List<DrinkInsertItem> coldDrinks;
        private List<DrinkInsertItem> alcoholDrinks;

        private TextBox TBcola, TBcolaZero, TBsprite, TBfuzeGreen, TBfuzeSparkling, TBfuzeBlack, TBfanta, TBcassis, TBo2Geel, TBo2Rood, TBo2Groen, TBredbull, TBfristi, TBchocomel, TBspaRood;
        private TextBox TBhj, TBjupiler, TBliefmans, TBleffeBlond, TBpalm, TBhoegaarde, TBwitteWijn, TBrodeWijn, TBbacardi, TBbacardiR;

        public CorrectionScreen()
        {
            InitializeComponent();

            coldDrinks = new List<DrinkInsertItem>();
            alcoholDrinks = new List<DrinkInsertItem>();

            TBcola = (TextBox)cCola;
            TBcolaZero = (TextBox)cColaZ;
            TBsprite = (TextBox)cSprite;
            TBfuzeGreen = (TextBox)cFuzeG;
            TBfuzeSparkling = (TextBox)cFuzeS;
            TBfuzeBlack = (TextBox)cFuzeB;
            TBfanta = (TextBox)cFanta;
            TBcassis = (TextBox)cCassis;
            TBo2Geel = (TextBox)cO2Ge;
            TBo2Rood = (TextBox)cO2R;
            TBo2Groen = (TextBox)cO2Gr;
            TBredbull = (TextBox)cRedbull;
            TBfristi = (TextBox)cFristi;
            TBchocomel = (TextBox)cChocomel;
            TBspaRood = (TextBox)cSpaR;

            TBhj = (TextBox)cHertogJan;
            TBjupiler = (TextBox)cJupiler;
            TBliefmans = (TextBox)cLiefmans;
            TBleffeBlond = (TextBox)cLeffeB;
            TBpalm = (TextBox)cPalm;
            TBhoegaarde = (TextBox)cHoegaarde;
            TBwitteWijn = (TextBox)cWijnW;
            TBrodeWijn = (TextBox)cWijnR;
            TBbacardi = (TextBox)cBacardi;
            TBbacardiR = (TextBox)cBacardiR;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            coldDrinks.Add(new DrinkInsertItem("cola", Convert.ToInt32(TBcola.Text)));
            coldDrinks.Add(new DrinkInsertItem("cola_zero", Convert.ToInt32(TBcolaZero.Text)));
            coldDrinks.Add(new DrinkInsertItem("sprite", Convert.ToInt32(TBsprite.Text)));
            coldDrinks.Add(new DrinkInsertItem("fuze_green", Convert.ToInt32(TBfuzeGreen.Text)));
            coldDrinks.Add(new DrinkInsertItem("fuze_sparkling", Convert.ToInt32(TBfuzeSparkling.Text)));
            coldDrinks.Add(new DrinkInsertItem("fuze_blacktea", Convert.ToInt32(TBfuzeBlack.Text)));
            coldDrinks.Add(new DrinkInsertItem("fanta", Convert.ToInt32(TBfanta.Text)));
            coldDrinks.Add(new DrinkInsertItem("cassis", Convert.ToInt32(TBcassis.Text)));
            coldDrinks.Add(new DrinkInsertItem("o2_geel", Convert.ToInt32(TBo2Geel.Text)));
            coldDrinks.Add(new DrinkInsertItem("o2_rood", Convert.ToInt32(TBo2Rood.Text)));
            coldDrinks.Add(new DrinkInsertItem("o2_groen", Convert.ToInt32(TBo2Groen.Text)));

            //todo Correct this and add rest
            coldDrinks.Add(new DrinkInsertItem("cola_zero", Convert.ToInt32(TBcolaZero.Text)));
            coldDrinks.Add(new DrinkInsertItem("cola_zero", Convert.ToInt32(TBcolaZero.Text)));
            coldDrinks.Add(new DrinkInsertItem("cola_zero", Convert.ToInt32(TBcolaZero.Text)));
            coldDrinks.Add(new DrinkInsertItem("cola_zero", Convert.ToInt32(TBcolaZero.Text)));
        }
    }
}
