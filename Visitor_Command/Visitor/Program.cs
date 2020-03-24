using System;
using Visitor.Concretas;
using Visitor.Interfaces;

namespace Visitor
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int Healt_marine = 0;
            int Healt_marauder = 0;
            Ivisitor _Bullet;


            Console.Clear();
            ConsoleKeyInfo op;

            do
            {
                //Limpiar la pantalla
                Console.WriteLine("");
                Console.WriteLine("Menú - Patrón Visitor");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Que desea realizar.");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[A] - Ataque Marine");
                Console.WriteLine("[E] - Ataque Marauder ");
                Console.WriteLine("[Esc]Salirtnn");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);

                
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción [Ataque Marine]");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();


                        _Bullet = new  TankBullet();
                        ILightUnit _marine = new Marine();
                        if(Healt_marine != 0) { _marine.Health = Healt_marine; }
                        _marine.Accept(_Bullet);
                        Console.Write("El ataque fue de " + variables.Ataque_Marine + " puntos  negativos | Marine queda con un total de " + _marine.Health + " puntos" );
                        Healt_marine = _marine.Health;

                        break;

                    case ConsoleKey.E:

                        Console.WriteLine("Ud seleccionó la opción [Ataque Marauder]");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();

                        _Bullet = new TankBullet();
                        IArmoredUnit _marauder = new Marauder();
                        if(Healt_marauder != 0) { _marauder.Health = Healt_marauder; }
                        _marauder.Accept(_Bullet);
                        Console.Write("El ataque fue de " + variables.Ataque_Marauder + " puntos  negativos | Marauder queda con un total de " + _marauder.Health + " puntos");
                        Healt_marauder = _marauder.Health;

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
