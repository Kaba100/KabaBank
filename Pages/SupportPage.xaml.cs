using KabaBank.ViewModel;

namespace KabaBank.Pages;

public partial class SupportPage : ContentPage
{
	public SupportPage()
	{
		InitializeComponent();
		BindingContext = new SupportVM();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}