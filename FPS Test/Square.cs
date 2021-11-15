using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPS_Test
{
    class Square
    {
        public int x, y, xs, ys, size;
        public Square(int _x, int _y, int _size)
        {
            size = _size;
            x = _x - size;
            y = _y - size;
        }
    }
}
