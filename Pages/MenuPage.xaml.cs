using KabaBank.ViewModel;
namespace KabaBank.Pages;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();

		BindingContext = new Solution();
	}
}