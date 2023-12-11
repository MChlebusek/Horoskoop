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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            Button Ent_btn = new Button
            {
                Text = "Horoskop",
                BackgroundColor = Color.Azure
            };

            Ent_btn.Clicked += Ent_btn_Clicked;

            StackLayout st = new StackLayout
            {
                Children = { Ent_btn },
                BackgroundColor = Color.Beige
            };

            Content = st;
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HoroskoopPage());
        }
    }
}