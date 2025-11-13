namespace ConsoleAppPartialEvent.Utils;

public partial class Alert
{
    public partial void ShowAlert(string message);
    public partial event EventHandler? AlertFired;
}
