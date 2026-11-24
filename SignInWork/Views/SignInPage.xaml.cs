using SignInWork.ViewModels;

namespace SignInWork.Views;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
        BindingContext = new SignInViewModel();
    }
}