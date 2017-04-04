using System;

namespace carita
{
    abstract class GameObject 
    {
        protected int x;
        protected int y;
        protected char icon;

        public GameObject(int _x, int _y, char _icon)
        {
            SetX(_x);
            SetY(_y);
            SetIcon(_icon);
        }

        public GameObject()
        {
            x = 0;
            y = 0;
            icon = 'O';
        }

        public void SetX(int _x)
        {
            if (_x > Console.WindowWidth - 1)
                x = Console.WindowWidth - 1;
            else if (_x < 0)
                x = 0;
            else
                x = _x;
        }

        public void SetY(int _y)
        {
            if (_y > Console.WindowHeight - 1)
                y = Console.WindowHeight - 1;
            else if (_y < 0)
                y = 0;
            else
                y = _y;
        }

        public void SetIcon(char _icon)
        {
            icon = _icon;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public char GetIcon()
        {
            return icon;
        }

        public abstract void Movement(ConsoleKeyInfo flecha);
        public abstract void Movement();

        public void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }
    }
}
