using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero();
            CargarArchivo.Url = "assets/board.txt";
            tablero = CargarArchivo.Leer();

            while (true)
            {
                 tablero = Juego.CalcularProximo(tablero);
                 Imprimir.ImprimirTablero(tablero); 
            }

        }
    }
}
