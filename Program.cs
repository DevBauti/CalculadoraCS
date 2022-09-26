
namespace Calcu
{
    class Calcu
    {
        public static double DoOperation(double a, double b, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "s":
                    result = a + b;
                    break;
                case "r":
                    result = a - b;
                    break;
                case "m":
                    result = a * b;
                    break;
                case "d":
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    };
    class Programa
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Calculadora tonta\r");
            Console.WriteLine("------------------------\n");
            while (!endApp)
            {
                string a = "";
                string b = "";
                double result = 0;

                Console.WriteLine("Escribe un numero:");
                a = Console.ReadLine()!;

                double aa = 0;
                while (!double.TryParse(a, out aa))
                {
                    Console.WriteLine("Escribi un numero animal");
                    a = Console.ReadLine()!;
                }

                Console.WriteLine("Escribe un numero:");
                b = Console.ReadLine()!;

                double bb = 0;
                while (!double.TryParse(b, out bb))
                {
                    Console.WriteLine("Escribi un numero animal");
                    b = Console.ReadLine()!;
                }

                Console.WriteLine("Elegi la operacion:");
                Console.WriteLine("\ts - Suma");
                Console.WriteLine("\tr - Resta");
                Console.WriteLine("\tm - Multiplicacion");
                Console.WriteLine("\td - Division");
                Console.Write("Tu opcion? ");

                string op = Console.ReadLine()!;

                try
                {
                    result = Calcu.DoOperation(aa, bb, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Error matematico");
                    }
                    else Console.WriteLine("El resultado: {0:0.##}\n", result);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Algo salio muy mal y no sabemos que ^-^.\n - Detalles: " + e.Message);
                }
                Console.WriteLine("------------------------\n");

                Console.Write("presiona N y enter para cerrar la app: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
};
