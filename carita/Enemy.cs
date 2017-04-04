using System;

namespace carita
{
    class Enemy : GameObject
    {
        const int Sube = 1;
        const int Baja = 0;
        const int Der = 1;
        const int Izq = 0;
        int SubeBaja;
        int DerIzq;
        

        public Enemy(int _x, int _y, char _icon) : base(_x, _y, _icon)
        {
            Random rnd = new Random();
           SubeBaja = rnd.Next(2);
            DerIzq = rnd.Next(2);
        }

        public override void Movement()
        {

            if (y >= Console.WindowHeight - 1)
                SubeBaja = Sube;

            if (y <= 0)
                SubeBaja = Baja;

            if (x >= Console.WindowWidth - 1)
                DerIzq = Izq;

            if (x <= 0)
                DerIzq = Der;

           if (SubeBaja == Sube)
                y--;
            else
                y++;

            if (DerIzq == Der)
                x++;
            else
                x--;
        }

        public override void Movement(ConsoleKeyInfo flecha)
        {
            throw new NotImplementedException();
        }
    }
}
