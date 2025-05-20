using JorgeRamosTallerClase.Views;

namespace JorgeRamosTallerClase
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }



        private void GridLayout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridLayout());
           
        }
    }

}
