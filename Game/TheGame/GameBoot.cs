using System.Reflection;
using TheGameCommons;

namespace TheGame;

public class GameBoot
{
    private readonly string _welcomeText = "Welcome to the Game!";
    public void Start()
    {
        Console.WriteLine(_welcomeText);
        Console.WriteLine("Loading extension ...");
        var extensionAssembly = Assembly.LoadFrom("/Users/dmorozov/Work/GameExperiment/Extensions/TheGameExtension/bin/Debug/net7.0/TheGameExtension.dll");

        if (extensionAssembly != null)
        {
            Console.WriteLine("Initialize extension ...");

            var type = typeof(IGameExtension);
            var types = extensionAssembly.GetTypes()
                .Where(type.IsAssignableFrom);

            Console.WriteLine("Found " + types?.Count() + " extensions.");
            if (types != null)
            {
                foreach (var t in types)
                {
                    var extension = (IGameExtension?)Activator.CreateInstance(t);
                    if (extension != null)
                    {
                        Console.WriteLine("Response: " + extension.Ping());
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("FAILED. Unable to load extension.");
        }
    }
}