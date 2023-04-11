using MyKitchen.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MyKitchen.Views
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