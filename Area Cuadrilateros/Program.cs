using Cuadrilateros;

var figura = 0;
do
{
    Console.WriteLine("Elija la figura que quiera calcular el area");
    Console.WriteLine("1- Cuadrado");
    Console.WriteLine("2- Rectangulo");
    Console.WriteLine("3- Trapecio");
    Console.WriteLine("0- Salir");
    figura = int.Parse(Console.ReadLine());


     switch (figura)
    {
        case 1:
            var cuadrado = new Cuadrado();

            Console.WriteLine($"El area del cuadrado es {cuadrado.CalcularArea()}");
            Console.ReadKey();
            Console.Clear();

            break;
        case 2:
            var rectangulo = new Rectangulo();
            Console.WriteLine($"El area del rectangulo es {rectangulo.CalcularArea()}");
            Console.ReadKey();
            Console.Clear();
            break;

        case 3:
            var trapecio = new Trapecio();
            Console.WriteLine($"El area del trapecio es {trapecio.CalcularArea()}");
            Console.ReadKey();
            Console.Clear();
            break;

        case 0: break;
        default:
            Console.WriteLine("Valor ingresado incorrecto");

            break;

    }



}
while (figura != 0);