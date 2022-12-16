
namespace MaApp;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Login_Clicked(object sender, EventArgs e)
    {
		// Logged in successfully, assign proper permission for this user.
		// Flyout should only make those permissible items visible.
		(Shell.Current as AppShell).Permissions = new Dictionary<string, int> { { "announcement", 1 }, { "specification", 0 }, { "order", 1 }, { "schedule", 0 }, { "sharedtask", 1 } };
        await Navigation.PushAsync(new AnnouncementsPage());
    }
}