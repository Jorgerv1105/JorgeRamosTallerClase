namespace JorgeRamosTallerClase.Views;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private void FlexLayout_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }

    private void Atras_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}