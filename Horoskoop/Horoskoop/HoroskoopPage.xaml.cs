using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horoskoop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HoroskoopPage : ContentPage
    {
        public HoroskoopPage()
        {
            InitializeComponent();
        }

        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime selectedDate = e.NewDate;
            DetermineZodiacSign(selectedDate);
        }

        private void OnZodiacEntryChanged(object sender, TextChangedEventArgs e)
        {
            string enteredZodiac = e.NewTextValue;
            DetermineZodiacSign(enteredZodiac);
        }

        private void DetermineZodiacSign(DateTime selectedDate)
        {
            string zodiacSign = "";

            // Определение знака зодиака по дате
            if ((selectedDate.Month == 3 && selectedDate.Day >= 21) || (selectedDate.Month == 4 && selectedDate.Day <= 19))
                zodiacSign = "Jäär"; // Овен
            else if ((selectedDate.Month == 4 && selectedDate.Day >= 20) || (selectedDate.Month == 5 && selectedDate.Day <= 20))
                zodiacSign = "Sõnn"; // Телец
            else if ((selectedDate.Month == 5 && selectedDate.Day >= 21) || (selectedDate.Month == 6 && selectedDate.Day <= 20))
                zodiacSign = "Kaksikud"; // Близнецы
            else if ((selectedDate.Month == 6 && selectedDate.Day >= 21) || (selectedDate.Month == 7 && selectedDate.Day <= 22))
                zodiacSign = "Vähk"; // Рак
            else if ((selectedDate.Month == 7 && selectedDate.Day >= 23) || (selectedDate.Month == 8 && selectedDate.Day <= 22))
                zodiacSign = "Lõvi"; // Лев
            else if ((selectedDate.Month == 8 && selectedDate.Day >= 23) || (selectedDate.Month == 9 && selectedDate.Day <= 22))
                zodiacSign = "Neitsi"; // Дева
            else if ((selectedDate.Month == 9 && selectedDate.Day >= 23) || (selectedDate.Month == 10 && selectedDate.Day <= 22))
                zodiacSign = "Kaalud"; // Весы
            else if ((selectedDate.Month == 10 && selectedDate.Day >= 23) || (selectedDate.Month == 11 && selectedDate.Day <= 21))
                zodiacSign = "Skorpion"; // Скорпион
            else if ((selectedDate.Month == 11 && selectedDate.Day >= 22) || (selectedDate.Month == 12 && selectedDate.Day <= 21))
                zodiacSign = "Ambur"; // Стрелец
            else if ((selectedDate.Month == 12 && selectedDate.Day >= 22) || (selectedDate.Month == 1 && selectedDate.Day <= 19))
                zodiacSign = "Kaljukits"; // Козерог
            else if ((selectedDate.Month == 1 && selectedDate.Day >= 20) || (selectedDate.Month == 2 && selectedDate.Day <= 18))
                zodiacSign = "Veevalaja"; // Водолей
            else if ((selectedDate.Month == 2 && selectedDate.Day >= 19) || (selectedDate.Month == 3 && selectedDate.Day <= 20))
                zodiacSign = "Kalad"; // Рыбы

            DisplayZodiacInfo(zodiacSign);
        }

        private void DetermineZodiacSign(string enteredZodiac)
        {
            string zodiacSign = "";

            // Определение знака зодиака по введенному тексту
            switch (enteredZodiac.ToLower())
            {
                case "jäär":
                    zodiacSign = "Jäär";
                    break;
                case "sõnn":
                    zodiacSign = "Sõnn";
                    break;
                case "kaksikud":
                    zodiacSign = "Kaksikud";
                    break;
                case "vähk":
                    zodiacSign = "Vähk";
                    break;
                case "lõvi":
                    zodiacSign = "Lõvi";
                    break;
                case "neitsi":
                    zodiacSign = "Neitsi";
                    break;
                case "kaalud":
                    zodiacSign = "Kaalud";
                    break;
                case "skorpion":
                    zodiacSign = "Skorpion";
                    break;
                case "ambur":
                    zodiacSign = "Ambur";
                    break;
                case "kaljukits":
                    zodiacSign = "Kaljukits";
                    break;
                case "veevalaja":
                    zodiacSign = "Veevalaja";
                    break;
                case "kalad":
                    zodiacSign = "Kalad";
                    break;
                default:
                    zodiacSign = "Tundmatu tähtkuju";
                    break;
            }

            DisplayZodiacInfo(zodiacSign);
        }

        private void DisplayZodiacInfo(string zodiacSign)
        {
            // Отображение информации о знаке зодиака
            switch (zodiacSign.ToLower())
            {
                case "jäär":
                    zodiacImage.Source = ImageSource.FromFile("jäär.png");
                    zodiacLabel.Text = "Jäär - 21. märts kuni 19. aprill\nMõned kirjeldused Jäära kohta.";
                    break;
                case "sõnn":
                    zodiacImage.Source = ImageSource.FromFile("sõnn.png");
                    zodiacImage.Source = ImageSource.FromFile("sõnn.png");
                    zodiacLabel.Text = "Sõnn - 20. aprill kuni 20. mai\nMõned kirjeldused Sõnni kohta.";
                    break;
                case "kaksikud":
                    zodiacImage.Source = ImageSource.FromFile("kaksikud.png");
                    zodiacLabel.Text = "Kaksikud - 21. mai kuni 20. juuni\nMõned kirjeldused Kaksikutest.";
                    break;
                case "vähk":
                    zodiacImage.Source = ImageSource.FromFile("vähk.png");
                    zodiacLabel.Text = "Vähk - 21. juuni kuni 22. juuli\nMõned kirjeldused Vähi kohta.";
                    break;
                case "lõvi":
                    zodiacImage.Source = ImageSource.FromFile("lõvi.png");
                    zodiacLabel.Text = "Lõvi - 23. juuli kuni 22. august\nMõned kirjeldused Lõvi kohta.";
                    break;
                case "neitsi":
                    zodiacImage.Source = ImageSource.FromFile("neitsi.png");
                    zodiacLabel.Text = "Neitsi - 23. august kuni 22. september\nMõned kirjeldused Neitsi kohta.";
                    break;
                case "kaalud":
                    zodiacImage.Source = ImageSource.FromFile("kaalud.png");
                    zodiacLabel.Text = "Kaalud - 23. september kuni 22. oktoober\nMõned kirjeldused Kaalude kohta.";
                    break;
                case "skorpion":
                    zodiacImage.Source = ImageSource.FromFile("skorpion.png");
                    zodiacLabel.Text = "Skorpion - 23. oktoober kuni 21. november\nMõned kirjeldused Skorpioni kohta.";
                    break;
                case "ambur":
                    zodiacImage.Source = ImageSource.FromFile("ambur.png");
                    zodiacLabel.Text = "Ambur - 22. november kuni 21. detsember\nMõned kirjeldused Amburi kohta.";
                    break;
                case "kaljukits":
                    zodiacImage.Source = ImageSource.FromFile("kaljukits.png");
                    zodiacLabel.Text = "Kaljukits - 22. detsember kuni 19. jaanuar\nMõned kirjeldused Kaljukitse kohta.";
                    break;
                case "veevalaja":
                    zodiacImage.Source = ImageSource.FromFile("veevalaja.png");
                    zodiacLabel.Text = "Veevalaja - 20. jaanuar kuni 18. veebruar\nMõned kirjeldused Veevalaja kohta.";
                    break;
                case "kalad":
                    zodiacImage.Source = ImageSource.FromFile("kalad.png");
                    zodiacLabel.Text = "Kalad - 19. veebruar kuni 20. märts\nMõned kirjeldused Kalade kohta.";
                    break;
                default:
                    zodiacImage.Source = null;
                    zodiacLabel.Text = "Tundmatu tähtkuju";
                    break;
            }
        }
    }
}