using ChessDependencyInversion.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWorkShop
{
    public class ScoreBoard
    {
        private readonly IRenderer renderer;
        public ScoreBoard(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public void DrawScore()
        {
            Console.WriteLine("Score is: 1488");
        }
    }
}
