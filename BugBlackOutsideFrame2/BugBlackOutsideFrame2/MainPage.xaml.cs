namespace BugBlackOutsideFrame2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnPopupClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new PopupPage());
    }
}


