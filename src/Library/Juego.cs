namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase que contiene la logica del juego de la vida y permite calcular el proximo tablero.
    /// Tiene como unica responsabilidad el calcular el proximo estado, y tiene como colaborador
    /// a la clase Tablero.
    /// 
    /// Cumple con el principio SRP ya que tiene la unica responsabilidad de calcular el proximo
    /// estado. Tambien cumple con Expert ya que esta responsabilidad requiere el conocimiento de
    /// logica para calcular el siguiente estado, el cual se encuentra en esta clase.
    /// </summary>
    public class Juego
    {
        static public Tablero CalcularProximo(Tablero tableroActual)
        {
            bool[,] gameBoard = tableroActual.Datos;
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);

            bool[,] cloneboard = new bool[boardWidth, boardHeight];
            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(gameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (gameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        cloneboard[x,y] = false;
                    }
                    else if (gameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        cloneboard[x,y] = false;
                    }
                    else if (!gameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        cloneboard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        cloneboard[x,y] = gameBoard[x,y];
                    }
                }
            }

            Tablero tableroProximo = new Tablero();
            tableroProximo.Datos = cloneboard;
            //gameBoard = cloneboard;
            //cloneboard = new bool[boardWidth, boardHeight];

            return tableroProximo;
        }
    }
}