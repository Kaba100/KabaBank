using KabaBank.ViewModel;

namespace KabaBank.Pages;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		
		BindingContext = new ProfileVM();
	}
}