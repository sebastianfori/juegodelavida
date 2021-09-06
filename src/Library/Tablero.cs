using System;

namespace PII_Game_Of_Life
{
    /// <summary>
    /// Clase que contiene los datos de un tablero, siendo este un array bidimensional de 1s y 0s.
    /// Tiene como unica responsabilidad el conocer estos datos.
    /// 
    /// Cumple con el principio SRP por tener una unica responsabilidad y el patron Expert por defecto ya 
    /// que no tiene responsabilidades de hacer (meotodos).
    /// </summary>
    public class Tablero
    {
        public bool[,] Datos;
    }
}
