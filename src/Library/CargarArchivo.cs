using System.IO;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase encargada de convertir un archivo con datos de tablero a un objeto del tipo Tablero.
    /// Tiene como una responsabiliad esta conversion, y como unico colaborador a la clase Tablero.
    /// 
    /// Cumple con el principio SRP ya que tiene una sola responsabilidad de convertir un archivo 
    /// de texto a un tablero. Tambien cumple con Expert ya que tiene la informacion de la ruta del
    /// archivo necesaria para convertirlo.
    /// </summary>
    public class CargarArchivo
    {
        static public string Url { get; set; }

        static public Tablero Leer()
        {
            string content = File.ReadAllText(Url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }

            Tablero newTablero = new Tablero();
            newTablero.Datos = board;

            return newTablero;
        }
    }
}