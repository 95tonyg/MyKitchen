using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MyKitchen.ViewModels
{
    public class KitchenViewModel : ItemsViewModel
    {
        public KitchenViewModel()
        {
            Title = "My Kitchen";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://google.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}