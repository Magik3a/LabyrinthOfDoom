
namespace LabyrinthOfDoom
{
    class Level2Matrix
    {
        public static bool[][] GetMatrix()
        {
            bool[][] mazeLayout = 
                {
                    new[] {true, true, true, true, true, true, true, true},
                    new[] {true, true, true, true, true, true, true, true},
                    new[] {true, false, false, false, false, false, false, true},
                    new[] {true, false, true, true, true, true, false, true},
                    new[] {true, false, true, false, false, false, false, true},
                    new[] {true, false, true, false, false, false, false, true},
                    new[] {true, false, true, false, false, false, false, true},
                    new[] {true, false, true, false, true, true, true, true},
                    new[] {true, false, true, false, false, false, false, true},
                    new[] {true, false, true, true, true, true, false, true},
                    new[] {true, false, false, false, false, false, false, false},
                    new[] {true, true, true, true, true, true, true, true}
                };

            return mazeLayout;
        }

    }

}

