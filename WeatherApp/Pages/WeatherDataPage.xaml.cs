using WeatherApp.Models.ViewsModels;

namespace WeatherApp.Pages;

public partial class WeatherDataPage : ContentPage
{
	public WeatherDataPage()
	{
		InitializeComponent();
        BindingContext = new WeatherDataPageViewModel();

 
    }
    private void OnArrowBackButtonClicked(object sender, EventArgs e)
    {
        // Handle the back button click event here
        // For example, navigate to the previous page
        //Navigation.PopAsync();
     }
}