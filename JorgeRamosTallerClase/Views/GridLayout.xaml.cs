namespace JorgeRamosTallerClase.Views;

public partial class GridLayout : ContentPage
{
	public GridLayout()
	{
		InitializeComponent();
	}

    private void Stack_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new StackLayout ());
    }
}