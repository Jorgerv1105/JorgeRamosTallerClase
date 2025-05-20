namespace JorgeRamosTallerClase.Views;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private async void OnGoToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayout());
    }
}