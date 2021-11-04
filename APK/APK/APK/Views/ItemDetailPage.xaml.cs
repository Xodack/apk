using APK.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace APK.Views
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