namespace DotNetMauiApp.Utils;

public class HLSpan : Span
{
	public static readonly BindableProperty UrlProperty =
		BindableProperty.Create(nameof(Url), typeof(string), typeof(HLSpan), null);

	public string Url
	{
		get { return (string)GetValue(UrlProperty); }
		set { SetValue(UrlProperty, value); }
	}

	public HLSpan()
	{
		TextDecorations = TextDecorations.Underline;
		TextColor = Colors.Blue;
		GestureRecognizers.Add(new TapGestureRecognizer {
			// Launcher.OpenAsync is provided by Essentials.
			Command = new Command(async () => await Launcher.OpenAsync(Url))
		});
	}
}
