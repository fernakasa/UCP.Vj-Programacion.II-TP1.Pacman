using System;

namespace Pacman_Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programacion II - TP 1: PACMAN");

            //Se inicializa un escenario de 10 x 10
            var escenario = new Escenario(10, 10);
			Console.WriteLine(escenario);
            
            //Se inicializa el Pacman en la posicion [5,5]
            var pacman = new Pacman("Pacman",escenario.ObtenerCeldaEnPosicion(5,5));
           

            //Se inicializa Pieza Puntos para posicion [4,5]
            Piezas pieza1 = new Piezas("Puntos"); 
            escenario.ObtenerCeldaEnPosicion(4,5).SetPieza(pieza1);

            //Muevo Pacman a la posicion [4,5]
            pacman.Mover(escenario.ObtenerCeldaEnPosicion(4,5));
            Console.WriteLine($"Pacman se encuentra en la celda({pacman.GetPosicion().GetPosX()},{pacman.GetPosicion().GetPosY()})");

            //Se inicializa Pieza Puntos para posicion [4,5]
            Piezas pieza2 = new Piezas("Puntos"); 
            escenario.ObtenerCeldaEnPosicion(3,5).SetPieza(pieza2);

            //Se inicializa Pieza Puntos para posicion [4,5]
            Piezas pieza3 = new Piezas("Puntos"); 
            escenario.ObtenerCeldaEnPosicion(2,5).SetPieza(pieza3);

            //Se inicializa Pieza Puntos para posicion [4,5]
            Piezas pieza4 = new Piezas("Puntos"); 
            escenario.ObtenerCeldaEnPosicion(2,4).SetPieza(pieza4);

            //Muevo Pacman a la posicion [4,5]
            pacman.Mover(escenario.ObtenerCeldaEnPosicion(4,5));
            Console.WriteLine($"Pacman se encuentra en la celda({pacman.GetPosicion().GetPosX()},{pacman.GetPosicion().GetPosY()})");
        }
    }
}
