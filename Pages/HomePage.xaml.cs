using KabaBank.ViewModel;
using KabaBank.Model;

namespace KabaBank.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		BindingContext = new Solution();

		if (DateTime.Now.Hour< 12)
		{
			GreetingLabel.Text = "Good Morning!";
		}
		else if( DateTime.Now.Hour>= 12 && DateTime.Now.Hour<16)
		{
			GreetingLabel.Text = "Good Afternoon!";
		}
		else if(DateTime.Now.Hour>16)
		{
			GreetingLabel.Text = "Good Evening!";
		}
	}
}