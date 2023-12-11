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
        Label resultLabel;
        Image zodiacImage;
        Label zodiacDescriptionLabel;

        public HoroskoopPage()
        {

            var datePicker = new DatePicker
            {
                Format = "D",
                MaximumDate = DateTime.Now
            };


            var submitButton = new Button
            {
                Text = "Submit",
                Command = new Command(() => ShowHoroscope(datePicker.Date))

            };

            resultLabel = new Label();
            zodiacImage = new Image();
            zodiacDescriptionLabel = new Label();

            //Main content
            Content = new StackLayout
            {

                Margin = new Thickness(20),


                Children =
            {

                new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        new Label { Text = "Select your birthdate:" },
                        datePicker
                    }
                },

                submitButton,
                resultLabel,
                zodiacImage,
                zodiacDescriptionLabel
            }
            };
        }

        private void ShowHoroscope(DateTime birthdate)
        {

            string zodiacSign = GetZodiacSign(birthdate);


            resultLabel.Text = $"Your zodiac sign is {zodiacSign}.";


            DisplayZodiacInfo(zodiacSign);


            zodiacDescriptionLabel.FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label));
        }


        private string GetZodiacSign(DateTime birthdate)
        {
            if ((birthdate.Month == 3 && birthdate.Day >= 21) || (birthdate.Month == 4 && birthdate.Day <= 19))
            {
                return "Aries";
            }
            else if ((birthdate.Month == 4 && birthdate.Day >= 20) || (birthdate.Month == 5 && birthdate.Day <= 20))
            {
                return "Taurus";
            }
            else if ((birthdate.Month == 5 && birthdate.Day >= 21) || (birthdate.Month == 6 && birthdate.Day <= 20))
            {
                return "Gemini";
            }
            else if ((birthdate.Month == 6 && birthdate.Day >= 21) || (birthdate.Month == 7 && birthdate.Day <= 22))
            {
                return "Cancer";
            }
            else if ((birthdate.Month == 7 && birthdate.Day >= 23) || (birthdate.Month == 8 && birthdate.Day <= 22))
            {
                return "Leo";
            }
            else if ((birthdate.Month == 8 && birthdate.Day >= 23) || (birthdate.Month == 9 && birthdate.Day <= 22))
            {
                return "Virgo";
            }
            else if ((birthdate.Month == 9 && birthdate.Day >= 23) || (birthdate.Month == 10 && birthdate.Day <= 22))
            {
                return "Libra";
            }
            else if ((birthdate.Month == 10 && birthdate.Day >= 23) || (birthdate.Month == 11 && birthdate.Day <= 21))
            {
                return "Scorpio";
            }
            else if ((birthdate.Month == 11 && birthdate.Day >= 22) || (birthdate.Month == 12 && birthdate.Day <= 21))
            {
                return "Sagittarius";
            }
            else if ((birthdate.Month == 12 && birthdate.Day >= 22) || (birthdate.Month == 1 && birthdate.Day <= 19))
            {
                return "Capricorn";
            }
            else if ((birthdate.Month == 1 && birthdate.Day >= 20) || (birthdate.Month == 2 && birthdate.Day <= 18))
            {
                return "Aquarius";
            }
            else if ((birthdate.Month == 2 && birthdate.Day >= 19) || (birthdate.Month == 3 && birthdate.Day <= 20))
            {
                return "Pisces";
            }

            return "Unknown";
        }
        private void DisplayZodiacInfo(string zodiacSign)
        {

            switch (zodiacSign.ToLower())
            {
                case "aries":
                    zodiacImage.Source = "Jaar.jpg";
                    zodiacDescriptionLabel.Text = " людей, родившихся под знаком Овна, характер непростой. Их целеустремлённость однобока — её хватает ненадолго: " +
                        "они быстро увлекаются и настолько же быстро теряют интерес. Часто это становится причиной развития не вполне позитивных сценариев их жизни — " +
                        "участие в сомнительных сделках, погружение в рискованные профессии.";
                    break;
                case "taurus":
                    zodiacImage.Source = "Sonn.jpg";
                    zodiacDescriptionLabel.Text = "У родившихся под покровительством Тельца характер, несмотря на всё упорство, описанное выше, отличается пассивностью. " +
                        "Да, он готов работать до седьмого и далее пота. Но активно искать каких-то дополнительных " +
                        " возможностей он не станет, а просто продолжит уверенно заниматься своим делом. ";
                    break;
                case "gemini":
                    zodiacImage.Source = "Kaksikud.jpg";
                    zodiacDescriptionLabel.Text = "Близнецы — самый многогранный знак зодиака с рядом выдающихся качеств, которые окружающими не всегда воспринимаются верно." +
                        " Это очень тонкие, сложные и интересные люди. Их можно познавать всю жизнь и всякий раз открывать что-то новое.  " +
                        "Характер их легок и интересен. Они логичны, интеллектуальны, коммуникативны, позитивны, легки в жизни и общении, а еще имеют энциклопедический склад ума.";
                    break;
                case "cancer":
                    zodiacImage.Source = "Vahk.jpg";
                    zodiacDescriptionLabel.Text = "Раки поражают глубиной и красотой своего внутреннего мира." +
                        "Раки не склонны к открытому противостоянию, стараются сгладить острые углы и не допустить конфликта.  " +
                        "Но если прижать к стенке, то будут ожесточенно бороться. Представителям этого знака бывает довольно сложно делиться своими эмоциями и переживаниями с другими людьми. ";
                    break;
                case "leo":
                    zodiacImage.Source = "Lovi.jpg";
                    zodiacDescriptionLabel.Text = "У Львов есть склонность к управлению — это сильные личности, настроенные на завоевание мира. " +
                        "Лев стремится к вершине успеха и достигает ее потому, что знает, чего хочет.   " +
                        "Его характер настолько непредсказуем, насколько и силен. Знак невероятно обаятельный, яркий, любящий внимание. ";
                    break;
                case "virgo":
                    zodiacImage.Source = "Neitsi.jpg";
                    zodiacDescriptionLabel.Text = "Не бойтесь довериться Деве — представитель знака всегда поддержит и встанет на вашу сторону, если что-то пойдет не так. " +
                        "Дева — настоящий реалист. Она смотрит на жизнь так, что та иногда кажется ей немного страшной.  " +
                        "Но при этом Дева не боится брать ответственность, умеет управляться с деньгами и знает им цену. ";
                    break;
                case "libro":
                    zodiacImage.Source = "Kaalud.jpg";
                    zodiacDescriptionLabel.Text = "Рожденные под покровительство Венеры Весы — утонченные эстеты, творцы, обладатели особого взгляда на мир. " +
                        "Они спокойны, рассудительны, дипломатичны, обладают острым чувством справедливости. " +
                        "Это один из самых комфортных в общении знаков зодиака. Весам часто не хватает уверенности в себе и решительности..";
                    break;
                case "scorpio":
                    zodiacImage.Source = "Skorpion.jpg";
                    zodiacDescriptionLabel.Text = "Человек, рожденный под знаком Скорпиона, сочетает в себе противоречивые черты. Он может быть сдержанным в проявлении чувств и даже казаться холодным, но в душе это очень эмоциональный человек." +
                        "н прямолинеен, умен, не лезет за словом в карман. " +
                        " Обладает невероятной стойкостью, с достоинством выдерживает любые испытания и идет к цели несмотря ни на что. Честолюбив и амбициозен. ";
                    break;

                case "sagittarius":
                    zodiacImage.Source = "Ambur.jpg";
                    zodiacDescriptionLabel.Text = "Огненная стихия оказывает сильное воздействие на характер Стрельца. " +
                        "ти излучающие оптимизм люди заряжают окружающих своей энергией. " +
                        " Стрельцы прекрасно проявляют себя на ниве преподавательской деятельности, но могут с успехом податься и в политику.";
                    break;
                case "capricorn":
                    zodiacImage.Source = "Kaljukits.jpg";
                    zodiacDescriptionLabel.Text = "Они выделяются амбициозностью и стойкостью. Козероги стараются избегать двусмысленных ситуаций и прямых конфликтов. " +
                        " Такая позиция помогает им обходиться в жизни без явных врагов. Козероги предпочитают все держать в себе: не делиться душевным состоянием с окружающими, также как и не высказывать открыто негатив. " +
                        " Внешне они спокойные, немногословные, отстраненные. Как никто, умеют совладать с эмоциями и подчинять их логике и разуму. ";
                    break;
                case "aquarius":
                    zodiacImage.Source = "Veevalaja.jpg";
                    zodiacDescriptionLabel.Text = "Водолей — реалист, который стремится изменить мир к лучшему. " +
                        " В нем всегда бурлит творческая энергия, гениальные мысли, планы и задумки." +
                        "При этом Водолей никогда не остановится на половине пути к намеченной цели и всегда будет идти до победного конца. ";
                    break;
                case "pisces":
                    zodiacImage.Source = "Kalad.jpg";
                    zodiacDescriptionLabel.Text = "Рыбы — утончённые натуры, отличающиеся чувственностью и проницательностью. " +
                        " Они всегда готовы прийти на помощь и поддержать в трудную минуту. Иногда отзывчивость делает их жертвами манипуляторов, " +
                        " но благодаря врождённой интуиции удаётся обернуть ситуацию в свою пользу, взяв всё под контроль.";
                    break;




                default:
                    zodiacImage.Source = null;
                    zodiacDescriptionLabel.Text = "No information available for this zodiac sign.";

                    break;
            }
        }
    }


}