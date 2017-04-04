using System;

namespace carita
{
    class Obstaculo : GameObject
    {
        public Obstaculo(int _x, int _y, char _icon):base (_x,_y,_icon)
        {

        }

        public override void Movement(ConsoleKeyInfo flecha)
        {
            throw new NotImplementedException();
        }

        public override void Movement()
        {
            throw new NotImplementedException();
        }
    }
}
