using System;
using System.Threading;

namespace carita
{
    class Juego
    {
        static bool multiplayer = true;

        static void GameOver(ref bool _inGame)
        {
            multiplayer = false;
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
            Console.SetCursorPosition(20, cont += 2);
            Console.WriteLine("Enter para volver a jugar (1 jugador) / Esc para salir / Espacio para 2 jugadores");
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
                    case ConsoleKey.Spacebar:
                        _inGame = true;
                        multiplayer = true;
                        break;
                }

            } while (salir.Key != ConsoleKey.Enter && salir.Key != ConsoleKey.Escape && salir.Key != ConsoleKey.Spacebar);

        }

        static void Menu(ref bool _inGame)
        {
            ConsoleKeyInfo salir = new ConsoleKeyInfo();
            int cont = (Console.WindowHeight - 9) / 2;
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, cont++);
            Console.WriteLine("  ▀█ █  █ ▄▀▀▀ ▄▀▀▄ █▀▀▄     █▀▀▀ █▄ █ ▀█▀ █▀▀▀ █▀▀▄");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, cont++);
            Console.WriteLine("▄  █ █  █ █ ▀█ █▄▄█ █▄▄▀ ▀▀▀ █▀▀▀ █ ▀█  █  █▀▀▀ █▄▄▀");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, cont++);
            Console.WriteLine(" ▀▀   ▀▀   ▀▀▀ ▀  ▀ ▀  ▀ ▀▀▀ ▀▀▀▀ ▀  ▀  ▀  ▀▀▀▀ ▀  ▀");
            Console.SetCursorPosition((Console.WindowWidth - 52) / 2, cont++);
            Console.WriteLine("                               ");
            Console.SetCursorPosition((Console.WindowWidth - 57) / 2, cont++);
            Console.WriteLine("▄▀▀▀ ▄▀▀▄ █    ▀█▀ █▀▀▄     █▀▀▀ ▄▀▀▀ ▄▀▀▀ ▄▀▀▄ █▀▀▄ █▀▀▀");
            Console.SetCursorPosition((Console.WindowWidth - 57) / 2, cont++);
            Console.WriteLine(" ▀▀▄ █▄▄█ █     █  █▄▄▀ ▀▀▀ █▀▀▀  ▀▀▄ █    █▄▄█ █▄▄▀ █▀▀▀");
            Console.SetCursorPosition((Console.WindowWidth - 57) / 2, cont++);
            Console.WriteLine("▀▀▀  ▀  ▀ ▀▀▀▀ ▀▀▀ ▀  ▀ ▀▀▀ ▀▀▀▀ ▀▀▀   ▀▀▀ ▀  ▀ ▀    ▀▀▀▀");
            Console.SetCursorPosition(Console.WindowWidth /2 - 11 , cont+= 2);
            Console.WriteLine("ESPACIO  = 2 JUGADORES");

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
                    case ConsoleKey.Spacebar:
                        _inGame = true;
                        multiplayer = true;
                        break;
                }

            } while (salir.Key != ConsoleKey.Enter && salir.Key != ConsoleKey.Escape && salir.Key != ConsoleKey.Spacebar);
        }

        static void Dibujar(Player _player, Player _player2, Obstaculo[] _obstaculos, GameObject[] _enemys)
        {
            _player.Dibujar();
            if (multiplayer)
                _player2.Dibujar();
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

        static void Overlap(Player _player, Player _player2, GameObject[] _gameObjects, GameObject[] _gameObjects2, ref bool _inGame)
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
            if (multiplayer)
            {
                for (int i = 0; i < _gameObjects.Length; i++)
                {
                    if ((_player2.GetX() == _gameObjects[i].GetX()
                        && _player2.GetY() == _gameObjects[i].GetY()))
                    {
                        _inGame = false;
                    }
                }

                for (int i = 0; i < _gameObjects2.Length; i++)
                {
                    if ((_player2.GetX() == _gameObjects2[i].GetX() && _player2.GetY() == _gameObjects2[i].GetY()))
                    {
                        _inGame = false;
                    }
                }
            }
        }

        public void Play()
        {
            bool inGame = true;
            Menu(ref inGame);
            if(!multiplayer)
            {
                while (inGame)
                {
                    Random rnd = new Random();

                    ConsoleKeyInfo flecha = new ConsoleKeyInfo();
                    Player player = new Player(Console.WindowWidth / 2, Console.WindowHeight / 2, '█', false);
                    Player player2 = new Player(Console.WindowWidth / 2, Console.WindowHeight / 2, '♦', false);

                    Obstaculo[] obstaculos = new Obstaculo[10];
                    Enemy[] enemys = new Enemy[20];

                    for (int i = 0; i < enemys.Length; i++)
                    {
                        enemys[i] = new Enemy(rnd.Next(0, Console.WindowWidth - 1), rnd.Next(0, Console.WindowHeight - 1), 'O');
                    }

                    for (int i = 0; i < obstaculos.Length; i++)
                    {
                        obstaculos[i] = new Obstaculo(rnd.Next(0, Console.WindowWidth - 1), rnd.Next(0, Console.WindowHeight - 1), '▒');
                    }

                    while (inGame)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Dibujar(player, player2, obstaculos, enemys);

                        Thread.Sleep(100);

                        for (int i = 0; i < enemys.Length; i++)
                            enemys[i].Movement();

                        if (Console.KeyAvailable)
                            player.Movement(flecha);

                        Overlap(player, player2, obstaculos, enemys, ref inGame);

                        Console.Clear();
                    }
                    GameOver(ref inGame);
                }
            }
            else
            {
                while (inGame)
                {
                    Random rnd = new Random();

                    ConsoleKeyInfo flecha = new ConsoleKeyInfo();
                    Player player = new Player(Console.WindowWidth / 2, Console.WindowHeight / 2, '█', false);
                    Player player2 = new Player(Console.WindowWidth / 2 + 2, Console.WindowHeight / 2, '♦', true);

                    Obstaculo[] obstaculos = new Obstaculo[10];
                    Enemy[] enemys = new Enemy[20];

                    for (int i = 0; i < enemys.Length; i++)
                    {
                        enemys[i] = new Enemy(rnd.Next(0, Console.WindowWidth - 1), rnd.Next(0, Console.WindowHeight - 1), 'O');
                    }

                    for (int i = 0; i < obstaculos.Length; i++)
                    {
                        obstaculos[i] = new Obstaculo(rnd.Next(0, Console.WindowWidth - 1), rnd.Next(0, Console.WindowHeight - 1), '▒');
                    }

                    while (inGame)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 0);
                        Dibujar(player, player2, obstaculos, enemys);

                        Thread.Sleep(100);

                        for (int i = 0; i < enemys.Length; i++)
                            enemys[i].Movement();

                        if (Console.KeyAvailable)
                        {
                            player.Movement(flecha);
                            player2.Movement(flecha);
                        }

                        Overlap(player, player2, obstaculos, enemys, ref inGame);

                        Console.Clear();
                    }
                    GameOver(ref inGame);
                }
            }

        }
    }
}
