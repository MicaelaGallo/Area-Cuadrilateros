using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros
{
    public class Trapecio:Cuadrilatero
    {
        public Trapecio()
        {


        for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Escriba la coordenada X del vertice {i + 1}");

                CoordenadasX[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Escriba la coordenada Y del vertice {i + 1}");
                CoordenadasY[i] = int.Parse(Console.ReadLine());
            }

        }
        public override double CalcularArea()
        {
            double areaTrapecio = 0.5 * (((CoordenadasX[0] * CoordenadasY[1]) + (CoordenadasX[1] *
          CoordenadasY[2]) + (CoordenadasX[2] * CoordenadasY[3]) + (CoordenadasX[3] *
               CoordenadasY[0])) - ((CoordenadasX[0] * CoordenadasY[3]) +
               (CoordenadasX[3] * CoordenadasY[2]) + (CoordenadasX[2] *
                CoordenadasY[1]) + (CoordenadasX[1] * CoordenadasY[0])))
                ;

            return areaTrapecio;

        }

    }


}