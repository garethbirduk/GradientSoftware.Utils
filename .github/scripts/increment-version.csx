using System;

// Parse the current version from the command line argument
var currentVersion = args[0];
var parts = currentVersion.Split('.');
if (parts.Length != 3)
{
    Console.Error.WriteLine("Invalid version format.");
    Environment.Exit(1);
}

var major = int.Parse(parts[0]);
var minor = int.Parse(parts[1]);
var patch = int.Parse(parts[2]);

// Increment the patch version
patch++;

// Output the new version
Console.WriteLine($"{major}.{minor}.{patch}");