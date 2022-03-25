using System.Reflection;
using System;
// if you run this program it will output it's informational version attribute.
var version = Assembly.GetEntryAssembly()!.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion ?? "empty or not set during build";
Console.WriteLine($"Hello, World! this is version: {version}");
