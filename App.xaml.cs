namespace DotNetMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		var window = base.CreateWindow(activationState);
		{
			var info = DeviceDisplay.Current.MainDisplayInfo;
			var scale = 1.0 / info.Density;
			var width = info.Width * scale;
			var height = info.Height * scale;
			window.Width = width / 2;
			window.Height = height / 2;
			Log($"Window: {width}x{height}");

			var theme = Application.Current.RequestedTheme;
			Log($"Theme: {theme.ToString()}");

			return window;
		}
	}

	public static void Log(string message)
	{
		System.Diagnostics.Debug.WriteLine(message);
	}
}
