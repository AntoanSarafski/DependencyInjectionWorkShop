using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependecyInversionRealExample
{
    public class Program
    {
        static void Main(string[] args)
        {

            ServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IRenderer, ConsoleRenderer>();

            serviceCollection.AddTransient<ChessEngine, ChessEngine>();



            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();



            ChessEngine chess = serviceProvider.GetService<ChessEngine>();

            chess.Start();
        }
    }
}
