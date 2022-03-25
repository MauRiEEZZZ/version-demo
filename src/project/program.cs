using System.Reflection;
// if you run this program it will output it's informational version attribute.
var version = Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "empty or not set during build";
Console.WriteLine($"Hello, World! thi is version: {version}");
