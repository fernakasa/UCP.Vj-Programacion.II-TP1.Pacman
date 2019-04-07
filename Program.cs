using System;
using System.Text;
using System.Threading;
class Program{
    static void Main(string[] args){
        Console.SetWindowSize(53,33);
        Console.SetBufferSize(53,34);
        Console.OutputEncoding = Encoding.UTF8;
        Console.CursorVisible = false;
        ConsoleKeyInfo Info = new ConsoleKeyInfo(' ', ConsoleKey.LeftArrow, false, false, false);
        Escenario esc = new Escenario();
        Pacman player = new Pacman();
        Fantasmas fantasma1 = new Fantasmas();
        Fantasmas fantasma2 = new Fantasmas();
        esc.SetPosicion(player.GetX(),player.GetY(),player.GetCaracter());
        esc.SetPosicion(fantasma1.GetX(),fantasma1.GetY(),fantasma1.GetCaracter());
        esc.SetPuntos(100);
        esc.SetVidas(3);
        do{
            if(Console.KeyAvailable){
                Info = Console.ReadKey(true);
                player.Move(Info, esc);
            }
            fantasma1.Move(esc, player);
            esc.Imprimir();

            if (player.GetPowerTime() > 0){
                Console.SetCursorPosition(30,31);
                Console.Write($"- Power Time: {player.GetPowerTime()}");
            }

            Thread.Sleep(67);
            if (player.GetDie() == true){
                break;
            }
        } while (Info.Key != ConsoleKey.Escape);
        Console.Clear();
        Console.WriteLine($"FIN!");
    }
}