using System;
using System.Threading;
using System.Text;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase que se encarga de imprimir a la consola el tablero provisto.
    /// Tiene como unica responsabilidad la impresion de un tablero, y como unico colaborador
    /// a la clase Tablero.
    /// 
    /// Cumple con el principio SRP ya que tiene una unica responsabilidad de imprimir el tablero
    /// recibido. 
    /// </summary>
    public class Imprimir
    {
        static public void ImprimirTablero(Tablero tablero)
        {
            bool[,] b = tablero.Datos;
            int width = b.GetLength(0);
            int height = b.GetLength(1);
            
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(b[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            Thread.Sleep(300);
        }
    }
}