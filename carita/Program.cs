using System;
using System.Threading;

namespace carita
{
    class Program
    {
        static void GameOver(ref bool _inGame)
        {
            ConsoleKeyInfo salir = new ConsoleKeyInfo();
            int cont = (Console.WindowHeight - 9) / 2;
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine(" ▄█▀▀▀▀  ▄█▀█▄  ██▄ ▄██ ██▀▀▀▀▀");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("██      ██   ██ ███████ ██▄▄▄▄");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("██  ▀██ ██▀▀▀██ ██ ▀ ██ ██▀▀▀▀");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine(" ▀█▄▄██ ██   ██ ██   ██ ██▄▄▄▄▄");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("                               ");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("▄█▀▀▀█▄ ██   ██ ██▀▀▀▀▀ ██▀▀▀█▄");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("██   ██ ██   ██ ██▄▄▄▄  ██  ▄██");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("██   ██  ▀█ █▀  ██▀▀▀▀  ██▀██▄");
            Console.SetCursorPosition((Console.WindowWidth - 31) / 2, cont++);
            Console.WriteLine("▀█▄▄▄█▀   ▀█▀   ██▄▄▄▄▄ ██  ██▄");
            Console.SetCursorPosition((Console.WindowWidth - 42) / 2, cont += 2);
            Console.WriteLine("Enter para volver a jugar o Esc para salir");
            Console.SetCursorPosition(0, 0);
            do
            {
                salir = Console.ReadKey();

                switch (salir.Key)
                {
                    case ConsoleKey.Escape:
                        _inGame = false;
                        break;
                    case ConsoleKey.Enter:
                        _inGame = true;
                        break;
                }
                
            } while (salir.Key != ConsoleKey.Enter && salir.Key != ConsoleKey.Escape);

        }

        static void Dibujar(Player _player , Obstaculo[] _obstaculos, GameObject[] _enemys)
        {
            _player.Dibujar();

            for (int i = 0; i < _obstaculos.Length; i++)
            {
                _obstaculos[i].Dibujar();
            }

            for (int i = 0; i < _enemys.Length; i++)
            {
                _enemys[i].Dibujar();
            }
            Console.SetCursorPosition(0, 0);
        }

        static void Overlap(Player _player , GameObject[] _gameObjects ,GameObject[] _gameObjects2, ref bool _inGame)
        {
            for (int i = 0; i < _gameObjects.Length; i++)
            {
                if ((_player.GetX() == _gameObjects[i].GetX() 
                    && _player.GetY() == _gameObjects[i].GetY()))
                {
                    _inGame = false;
                }
            }

            for (int i = 0; i < _gameObjects2.Length; i++)
            {
                if ((_player.GetX() == _gameObjects2[i].GetX() && _player.GetY() == _gameObjects2[i].GetY()))
                {
                    _inGame = false;
                }
            }
            


        }

        static void Main(string[] args)
        {
            bool inGame = true;
            
            while (inGame)
            {
                Random rnd = new Random();

                ConsoleKeyInfo flecha = new ConsoleKeyInfo();
                Player player = new Player(Console.WindowWidth / 2, Console.WindowHeight / 2, '♫');

                Obstaculo[] obstaculos = new Obstaculo[10];
                Enemy[] enemys = new Enemy[10];

                for (int i = 0; i < enemys.Length; i++)
                {
                    enemys[i] = new Enemy(rnd.Next(0, Console.WindowWidth-1), rnd.Next(0, Console.WindowHeight-1), 'O');
                }

                for (int i = 0; i < obstaculos.Length; i++)
                {
                    obstaculos[i] = new Obstaculo(rnd.Next(0, Console.WindowWidth-1), rnd.Next(0, Console.WindowHeight-1), '█');
                }
                
                while (inGame)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Dibujar(player, obstaculos, enemys);

                    Thread.Sleep(100);

                    for (int i = 0; i < enemys.Length; i++)
                        enemys[i].Movement();

                    if (Console.KeyAvailable)
                        player.Movement(flecha);
                    
                    Overlap(player, obstaculos,enemys, ref inGame);
                    
                    Console.Clear();
                }
                GameOver(ref inGame);
            }
        }
    }
}
