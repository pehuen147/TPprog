using System;


namespace carita
{
    class Player : GameObject
    {
        public Player(int _x , int _y , char _icon):base (_x,_y,_icon)
        {

        }

        public void Movement(ConsoleKeyInfo flecha)
        {
            flecha = Console.ReadKey();

            switch (flecha.Key)
            {
                case ConsoleKey.UpArrow:
                    if (y > 0)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (y < Console.WindowHeight - 1)
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (x > 0)
                    {
                        x--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (x < Console.WindowWidth - 1)
                    {
                        x++;
                    }
                    break;
            }
        }
    }
}
