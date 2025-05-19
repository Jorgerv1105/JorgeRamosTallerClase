namespace JorgeRamosTallerClase.Views;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}

    private void Atras_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayout());

    }

    private void FlexLayout_Clicked(object sender, EventArgs e)
    {

    }
}