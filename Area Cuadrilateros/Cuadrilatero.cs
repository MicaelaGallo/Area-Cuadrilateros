using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros
{
    public abstract class Cuadrilatero
    {
        private int[] _coordenadasX=new int[4];
        private int[] _coordenadasY= new int[4];

        public int [] CoordenadasX
        {
            get => _coordenadasX;
            set => _coordenadasX = value;
        }
        public int [] CoordenadasY
        {
            get => _coordenadasY;
            set => _coordenadasY = value;
        }


        public abstract double CalcularArea();
    



    }
}
