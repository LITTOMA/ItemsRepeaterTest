namespace ItemsRepeaterTest.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        irt.ItemsSource = Enumerable.Range(0, 100).Select(i => new { Text = $"Item {i}" });
    }
}
