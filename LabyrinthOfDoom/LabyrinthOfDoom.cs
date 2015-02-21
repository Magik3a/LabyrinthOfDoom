using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrinthOfDoom;
using System.Diagnostics;

namespace LabyrinthOfDoom
{
    class LabyrinthOfDoom
    {
        private const char wallchar = '\u2588';
        private const char mazechar = '\u0020';


        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 50);
            Console.Title = "Labyrinth Of Doom";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            for (int level = 2; level < 3; level++)
            {
                bool[][] mazeLayout = Level1Matrix.GetMatrix();
                switch (level)
                {
                    case 1: mazeLayout = Level2Matrix.GetMatrix(); break;
                    case 2: mazeLayout = Level3Matrix.GetMatrix(); break;
                    default: break;
                }
                Console.WriteLine("");
                //Make maze
                for (int i = 0; i < mazeLayout.Length; i++)
                {
                    for (int j = 0; j < mazeLayout[i].Length; j++)
                    {
                        Console.Write(( mazeLayout[i][j] ? wallchar : mazechar));
                    }
                    Console.Write("\n");
                }
                Movements.Move(level);



            }
            Console.WriteLine("\n\n\n\n   Yeaaaa You beat the game!");
            Console.ReadLine();
        }

    }
}


