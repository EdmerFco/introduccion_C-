using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    /// <summary>
    /// Un tipo de estructura (o tipo struct) es un tipo de valor que puede encapsular datos y funcionalidad relacionada. 
    /// Para definir un tipo de estructura se usa la palabra clave struct:
    /// </summary>
    public struct CoordenadaStruct
    {
        public CoordenadaStruct(double x, double y)
        {
            X = x;
            Y = y;
        }
   
        public double X { get; set; }
        public double Y { get; set; }
        public string Valores() => $"({X}, {Y})";

 
    }
    public struct OperacionesAritmeticas
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Operacion Oper { get; set; }
    }
    public enum Operacion
    {
        suma,
        resta,
        multiplicacion,
        division,
        modulo
    }


}
