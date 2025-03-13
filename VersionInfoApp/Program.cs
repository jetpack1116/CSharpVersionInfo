using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "Unknown";

        Console.WriteLine($"C# Project Version: {version}");
    }
}
