using Apuntes5543Group7.ViewModels;

namespace Apuntes5543Group7.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        BindingContext = new AboutViewModel();
    }
}