namespace FreshMAUIApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new MainPageContext();
    }
  

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Console.WriteLine("Called OnAppearing;height:{0},width:{1}",this.Height,this.Width);
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        Console.WriteLine("Called OnDisappearing; height:{0},width:{1}", this.Height, this.Width);
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        Console.WriteLine("Called OnSizeAllocated; height:{0},width:{1}", this.Height, this.Width);
        base.OnSizeAllocated(width, height);
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
        Console.WriteLine("Called OnCounterClicked; height:{0},width:{1}", this.Height, this.Width);
        count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

public class MainPageContext
{
    public string imgSource { get; set; } = "dotnet_bot.svg";
    public bool IsEnabledProp { get; set; } = true;
}


