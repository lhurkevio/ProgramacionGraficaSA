using OpenTK.Windowing.Common;
using System;

namespace ProgramacionGraficaSA
{

    class Program
    {
        static void Main(string[] args)
        {
            using (Game game = new Game(800, 600, "CarloGuzmanLopez"))
            {
                game.Run();
            }
        }
    }
}