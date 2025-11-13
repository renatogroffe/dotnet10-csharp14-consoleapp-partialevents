namespace ConsoleAppPartialEvent.Utils;

public partial class Alert
{
    public partial void ShowAlert(string message)
    {
        Console.WriteLine();
        var oldColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Alerta: {message}");
        Console.ForegroundColor = oldColor;
        _alertFired?.Invoke(this, EventArgs.Empty);
        Console.WriteLine();
    }

    private EventHandler? _alertFired;

    public partial event EventHandler? AlertFired
    {
        add
        {
            Console.WriteLine("Evento de alerta adicionado.");
            _alertFired += value;
        }
        remove
        {
            Console.WriteLine("Evento de alerta removido.");
            _alertFired -= value;
        }
    }
}
