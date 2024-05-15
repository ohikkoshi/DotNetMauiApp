namespace DotNetMauiApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

		// Default Theme
		themeSwitch.IsToggled = Application.Current.RequestedTheme == AppTheme.Dark;
	}

	void OnThemeToggled(object sender, ToggledEventArgs e)
	{
		// Perform an action after examining e.Value
		var theme = e.Value ? AppTheme.Dark : AppTheme.Light;
		Application.Current.UserAppTheme = theme;
	}
}
