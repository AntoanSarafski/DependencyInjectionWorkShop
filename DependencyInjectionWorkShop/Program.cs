using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;
using DependencyInjectionWorkShop;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependecyInversionRealExample
{
    public class Program
    {
        static void Main(string[] args)
        {

            IServiceProvider serviceProvider = ServiceConfigurator.ConfigureServices();


            ChessEngine chess = serviceProvider.GetService<ChessEngine>();


            ScoreBoard scoreBoard = serviceProvider.GetService<ScoreBoard>();

            scoreBoard.DrawScore()

            chess.Start();
        }
    }
}
