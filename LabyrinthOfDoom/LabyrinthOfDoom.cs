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
			Console.SetWindowSize(20, 20);
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.DarkBlue;

			Console.WriteLine("");
			bool[][] mazeLayout = Level1Matrix.GetMatrix();
		   
			//Make maze
			for (int i = 0; i < mazeLayout.Length; i++)
			{
				for (int j = 0; j < mazeLayout[i].Length; j++)
				{
					Console.Write(mazeLayout[i][j] ? wallchar : mazechar);
				}
				Console.Write("\n");
			}


			Console.WriteLine("");
			int col = 1;
			int row = 3;

			Console.SetCursorPosition(col, row);
			Console.Write("*");
			Console.SetCursorPosition(col, row);

			while(true)
			{
				ConsoleKeyInfo info = Console.ReadKey(true);
				if (info.Key == ConsoleKey.W && !mazeLayout[row - 2][col])
				{
					Console.Write(" ");
					Debug.Print("W");
					row--;
				}
				if (info.Key == ConsoleKey.S && !mazeLayout[row][col])
				{
					Console.Write(" ");
					Debug.Print("S");
					row++;
				}

				if (info.Key == ConsoleKey.A && !mazeLayout[row - 1][col - 1])
				{
					Console.Write(" ");
					Debug.Print("A");
					col--;
				}

				if (info.Key == ConsoleKey.D && !mazeLayout[row - 1][col + 1])
				{
					Console.Write(" ");
					Debug.Print("D");
					col++;
				}

				Console.SetCursorPosition(col, row);
				Console.Write("*");
				Console.SetCursorPosition(col, row);
				if (col == 7 && row == 11)
				{
                    Console.WriteLine("You Found the exit :)");
					return;
				}

			}
            
			
			
		}
	}
}


