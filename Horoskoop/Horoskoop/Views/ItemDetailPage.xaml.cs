using Horoskoop.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Horoskoop.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}