
namespace LabyrinthOfDoom
{
    class Level1Matrix
    {
        public static char[,] GetMatrix()
        {
            char[,] matrix =  {
                {'*','*', '*', '*', '*', '*', '*', '*', '*' ,'*'},
                {' ',' ', ' ', ' ', '*', ' ', ' ', ' ', ' ','*'},
                {'*','*', '*', ' ', '*', ' ', '*', '*', ' ','*'},
                {'*',' ', ' ', ' ', ' ', ' ', ' ', '*', ' ','*'}, 
                {'*',' ', '*', '*', '*', '*', '*', '*', ' ','*'}, 
                {'*',' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ',' '},
                {'*','*', '*', '*', '*', '*', '*', '*', '*','*'},
                };
            return matrix;
        }


        public static void PrintMatrix()
        {
            char[,] matrix = Level1Matrix.GetMatrix();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    System.Console.Write("{0, 2}", matrix[row, col]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
    }

}

