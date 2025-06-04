namespace Clase_Layouts.Views;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

    private void btnIrAAbsolute_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}