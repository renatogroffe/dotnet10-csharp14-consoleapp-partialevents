using ConsoleAppPartialEvent.Utils;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com C# 14 + .NET 10 | Partial Events *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

Console.WriteLine();

var alert = new Alert();
alert.AlertFired += SampleEventHandler;
alert.ShowAlert("Um primeiro alerta!");
alert.ShowAlert("Um segundo alerta!");
alert.AlertFired -= SampleEventHandler;

void SampleEventHandler(object? sender, EventArgs _)
{
    Console.WriteLine($"O evento de alerta foi disparado! Sender - Type: {sender?.GetType().Name}");
}