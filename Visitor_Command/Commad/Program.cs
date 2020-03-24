using System;
using Commad.Concretas;

namespace Commad
{
    class Program
    {
        static void Main(string[] args)
        {
           


            Console.Clear();
            ConsoleKeyInfo op;

            do
            {
                //Limpiar la pantalla
                Console.WriteLine("");
                Console.WriteLine("Menú - Patrón Command");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Que desea realizar.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A] - Mover una unidad");
                Console.WriteLine("[E] - Reunir recursos");
                Console.WriteLine("[Esc]Salirtnn");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);


                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción [Mover una unidad]");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();

                        Console.WriteLine("Ingrese el valor de X");
                        var _X = Console.ReadLine();
                        Console.WriteLine("Ingrese el valor de Y");
                        var _Y = Console.ReadLine();

                        var unit = new Probe();
                        var moveCommand = new MoveCommand(unit, Convert.ToInt32( _X), Convert.ToInt32( _Y));
                        moveCommand.Execute();
                        Console.Write("Las posiciones de movimiento fueron, X : " + unit.Position.X  +  " y  Y : " + unit.Position.Y);

                        break;

                    case ConsoleKey.E:

                        Console.WriteLine("Ud seleccionó la opción [Reunir recursos]");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();

                        var unit_ = new Probe();
                        var gatherCommand = new GatherCommand(unit_);
                        gatherCommand.Execute();

                        Console.Write("El valor fue de " +  unit_.Minerals);


                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Chao");

                        break;
                }
            } while (op.Key != ConsoleKey.Escape);

            Console.WriteLine("Hello World!");
        }
    }
}
