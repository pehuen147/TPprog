using System;


namespace carita
{
    class Player : GameObject
    {
        private bool numeroJugador = false;
        public Player(int _x , int _y , char _icon, bool _multiplayer):base (_x,_y,_icon)
        {
            numeroJugador = _multiplayer;//bool para instanciar jugador 1 o 2
        }

        public void Movement(ConsoleKeyInfo flecha)
        {
            flecha = Console.ReadKey();
            if (!numeroJugador)
            {
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
            }else
            {
                switch (flecha.Key)
                {
                    case ConsoleKey.W:
                        if (y > 0)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (y < Console.WindowHeight - 1)
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (x < Console.WindowWidth - 1)
                        {
                            x++;
                        }
                        break;
                }
            }
           
        }
    }
}
