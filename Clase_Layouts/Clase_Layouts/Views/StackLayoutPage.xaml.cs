namespace Clase_Layouts.Views;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}

    private void btnIrAFlex_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayoutPage());
    }
}