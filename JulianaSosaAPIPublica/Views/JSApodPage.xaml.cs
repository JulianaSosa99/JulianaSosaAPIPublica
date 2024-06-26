using JulianaSosaAPIPublica.ViewModels;

namespace JulianaSosaAPIPublica.Views;

public partial class JSApodPage : ContentPage
{
	public JSApodPage()
	{
		InitializeComponent();
		//this.BindingContext = new JSApodViewModel();
		BindingContext = new JSApodViewModel();
	}
}