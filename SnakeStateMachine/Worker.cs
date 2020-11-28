using System;

namespace SnakeStateMachine
{
    public class Worker
    {
        public Worker()
        {

        }

        public void Start()
        {
            Moving();
        }

        private void Moving()
        {
            SnakeStateMachine snake = new SnakeStateMachine();
            Console.WriteLine(snake.DirectionNames);
            while (true)
            {
                snake.changeddirection(Console.ReadKey(true));
                Console.WriteLine(snake.DirectionNames);
            }
        }

        private void PlaygroundArea()
        {
            Playground pga = new Playground();
            pga.AssignChar();
            pga.DrawPlayground();
        }
    }
}