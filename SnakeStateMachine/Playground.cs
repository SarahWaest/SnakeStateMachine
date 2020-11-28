using System;

namespace SnakeStateMachine
{
    public class Playground
    {
        private char[,] playground = new char[playgroundWidth, playgroundHeight];
        private static int playgroundWidth = 10;
        private static int playgroundHeight = 10;
        private int[,] snakePosition;

        public Playground(int height, int width)
        {
            playgroundHeight = height;
            playgroundWidth = width;
        }

        public Playground()
        {

          
        }

        public void DrawPlayground()
        {
            Console.WriteLine();
            for(int i = 0; i < playground.GetLength(0); i++)
            {
                for (int j = 0; j < playground.GetLength(1); j++)
                { ;
                    Console.Write(" ");
                }
                Console.WriteLine("X");
            }
        }

        public void AssignChar()
        {
            for (int i = 0; i < playground.GetLength(0); i++)
            {
                playground[i, 0] = 'X';
                playground[i, playground.GetLength(1) - 1] = 'X';
                for (int j = 0; j < playground.GetLength(1); j++)
                {
                    playground[0, j] = 'X';
                    playground[playground.GetLength(1)-1, j] = 'X';
                }
            }
        }
    }
}