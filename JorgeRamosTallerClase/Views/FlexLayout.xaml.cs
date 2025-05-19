namespace JorgeRamosTallerClase.Views;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void AbsoluteLayout_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new AbsoluteLayout());
    }
}