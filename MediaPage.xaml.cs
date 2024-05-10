namespace DotNetMauiApp;

public partial class MediaPage : ContentPage
{
	public MediaPage()
	{
		InitializeComponent();
	}

	void ContentPage_Loaded(object sender, EventArgs e)
	{
		// Start MediaElement when we navigate to this page
		mediaElement.Play();
	}

	void ContentPage_Unloaded(object sender, EventArgs e)
	{
		// Stop and cleanup MediaElement when we navigate away
		mediaElement.Pause();
		//mediaElement.Handler?.DisconnectHandler();
	}
}
