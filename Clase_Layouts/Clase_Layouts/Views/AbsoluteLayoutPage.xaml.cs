namespace Clase_Layouts.Views;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

    private void btnIrAGrid_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new GridLayoutPage());
    }
}