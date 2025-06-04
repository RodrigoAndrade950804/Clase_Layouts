using Clase_Layouts.Views;

namespace Clase_Layouts.Views
{
    public partial class GridLayoutPage : ContentPage
    {
        int count = 0;

        public GridLayoutPage()
        {
            InitializeComponent();
        }

        private void btnIrAStack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }
    }

}
