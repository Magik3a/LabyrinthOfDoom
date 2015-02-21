using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabyrinthOfDoom;


namespace LabyrinthOfDoom
{
    class LabyrinthOfDoom
    {
        static void Main(string[] args)
        {
            Console.Title = "Labyrinth Of Doom";
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Svetlio E pi4");

            Console.WriteLine("\n \n");
            
             Level1Matrix.PrintMatrix();
        }

        

        
    }
}


