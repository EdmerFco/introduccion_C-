using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IntroduccionCS
{
    /// <summary>
    /// Clase
    /// </summary>
    public class DeclaracionVariables
    {
        const int intConstante = 32;
        const string cadenaConstante = "Cadena constante global";
        public static void NumerosEnteros()
        {
            //sbyte De -128 a 127   Entero de 8 bits con signo System.SByte
            sbyte enteroSbyte;
            enteroSbyte = 127;
            Console.WriteLine(enteroSbyte);
            //byte De 0 a 255  Entero de 8 bits sin signo System.Byte
            byte enterobyte;
            enterobyte = 255;
            Console.WriteLine(enterobyte);
            //short De -32,768 a 32,767 Entero de 16 bits con signo System.Int16
            short enteroshort;
            enteroshort = -32767;
            Console.WriteLine(enteroshort);
            //ushort De 0 a 65,535   Entero de 16 bits sin signo System.UInt16
            ushort enteroushort;
            enteroushort = 65535;
            Console.WriteLine(enteroushort);
            //int De -2,147,483,648 a 2,147,483,647   Entero de 32 bits con signo System.Int32
            int enteroint;
            enteroint = 2147483647;
            Console.WriteLine(enteroint);
            //uint De 0 a 4,294,967,295    Entero de 32 bits sin signo System.UInt32
            uint enterouint;
            enterouint = 4294967295;
            Console.WriteLine(enterouint);
            //long De -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807   Entero de 64 bits con signo System.Int64
            long enterolong;
            enterolong = 922337236854775807;
            Console.WriteLine(enterolong);
            //ulong De 0 a 18,446,744,073,709,551,615   Entero de 64 bits sin signo System.UInt64
            ulong enteroulong;
            enteroulong = 18446744073709551615;
            Console.WriteLine(enteroulong);
        }


        public static void NumerosFraccionados()
        {
            //float De ±1,5 x 10 - 45 a ±3,4 x 1038   De 6 a 9 dígitos aproximadamente    4 bytes System.Single
            float flotante = 18446744073709551615.1234567890123456789f;
            Console.WriteLine(flotante);
            //double De ±5,0 × 10−324 a ±1,7 × 10308 De 15 a 17 dígitos aproximadamente  8 bytes System.Double
            double doble = 1844674407370.1234567890123456789d;
            Console.WriteLine(doble);
            //decimal De ±1,0 x 10 - 28 to ±7,9228 x 1028   28 - 29 dígitos   16 bytes System.Decimal
            decimal conDecimales = 1234567.458967m;
            Console.WriteLine(conDecimales);
        }
        public static void Cadenas()
        {
            char caracter;
            string  cadena;
            //Caracter - Asignación con comillas sencillas
            caracter = 'a';
            Console.WriteLine(caracter);
            // inicializar a nulos
            cadena = null;
            cadena  = String.Empty;
            cadena = "Esta es una cadena de caracteres";
            Console.WriteLine(cadena);
        }
        public static void Boleanos()
        {
            bool boleano;
            boleano = true;
            boleano = false;
            Console.WriteLine(boleano);
        }
        public static void Fechas()
        {
            // Fecha y Hora 
            DateTime fechaHora;
            fechaHora = new DateTime(2022, 1, 1, 8, 30, 52);
            Console.WriteLine(fechaHora);
        }


        public static void DeclaracionVar()
        {

            
            var aas = 127;
            Console.WriteLine(aas);
            var enterobyte = 255;
            Console.WriteLine(enterobyte);
            var enteroshort = -32767;
            Console.WriteLine(enteroshort);
            var enteroushort = 65535;
            Console.WriteLine(enteroushort);
            var enteroint = 2147483647;
            Console.WriteLine(enteroint);
            var enterouint = 4294967295;
            Console.WriteLine(enterouint);
            var enterolong = 922337236854775807;
            Console.WriteLine(enterolong);
            var enteroulong = 18446744073709551615;
            Console.WriteLine(enteroulong);
            var flotante = 18446744073709551615.1234567890123456789f;
            Console.WriteLine(flotante);
            var doble = 1844674407370.1234567890123456789d;
            Console.WriteLine(doble);
            var conDecimales = 1234567.458967m;
            Console.WriteLine(conDecimales);
            var caracter = 'a';
            Console.WriteLine(caracter);
            var cadena = "Esta es una cadena de caracteres";
            Console.WriteLine(cadena);
            var boleano = false;
            Console.WriteLine(boleano);
            var fechaHora = new DateTime(2021, 1, 1, 8, 30, 52);
            Console.WriteLine(fechaHora);
        }
        public static void DeclaracionVariablesNuleables()
        {
            //sbyte De -128 a 127   Entero de 8 bits con signo System.SByte
            sbyte? enteroSbyte;
            enteroSbyte = null;
            enteroSbyte = 127;
            Console.WriteLine(enteroSbyte);
            //byte De 0 a 255  Entero de 8 bits sin signo System.Byte
            byte? enterobyte;
            enterobyte = null;
            enterobyte = 255;
            Console.WriteLine(enterobyte);
            //short De -32,768 a 32,767 Entero de 16 bits con signo System.Int16
            short? enteroshort;
            enteroshort = null;
            enteroshort = -32767;
            Console.WriteLine(enteroshort);
            //ushort De 0 a 65,535   Entero de 16 bits sin signo System.UInt16
            ushort? enteroushort;
            enteroushort = null;
            enteroushort = 65535;
            Console.WriteLine(enteroushort);
            //int De -2,147,483,648 a 2,147,483,647   Entero de 32 bits con signo System.Int32
            int? enteroint;
            enteroint = null;
            enteroint = 2147483647;
            Console.WriteLine(enteroint);
            //uint De 0 a 4,294,967,295    Entero de 32 bits sin signo System.UInt32
            uint? enterouint;
            enterouint = null;
            enterouint = 4294967295;
            Console.WriteLine(enterouint);
            //long De -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807   Entero de 64 bits con signo System.Int64
            long? enterolong;
            enterolong = null;
            enterolong = 922337236854775807;
            Console.WriteLine(enterolong);
            //ulong De 0 a 18,446,744,073,709,551,615   Entero de 64 bits sin signo System.UInt64
            ulong? enteroulong;
            enteroulong = null;
            enteroulong = 18446744073709551615;
            Console.WriteLine(enteroulong);
            char? caracter;
            caracter = null;
            caracter = 'a';
            Console.WriteLine(caracter);
            bool? boleano;
            boleano = null;
            boleano = false;
            Console.WriteLine(boleano);
            DateTime? fecha;
            fecha = null;
            fecha = new DateTime(2021, 7, 10, 7, 10, 24);
            Console.WriteLine(fecha);
            int?[] arr = new int?[10];
        }

        /// <summary>
        /// Operador del indizador []
        ///Los corchetes, [], se usan para el acceso a matriz
        /// </summary>
        public static void Arreglos()
        {
            sbyte[] enterosSbyte = { 1, 2, 3};
            Console.WriteLine(enterosSbyte[0]);
            byte[] enterobyte = new byte[3];
            enterobyte[0] = 1;
            enterobyte[1] = 2;
            enterobyte[2] = 3;
            Console.WriteLine(enterobyte[0]);
            short[] enteroshort = { 1, 2, 3 };
            Console.WriteLine(enteroshort[0]);
            ushort[] enteroushort = { 1, 2, 3 };
            Console.WriteLine(enteroushort[0]);
            int[] enteroint = { 1, 2, 3 }; ;
            Console.WriteLine(enteroint[0]);
            uint[] enterouint = { 1, 2, 3 }; ;
            Console.WriteLine(enterouint);
             long[] enterolong = { 1, 2, 3 }; ;
            Console.WriteLine(enterolong);
            ulong[] enteroulong = { 1, 2, 3 }; ;
            Console.WriteLine(enteroulong);
            float[] flotante = { 18.789f,1.3f,2.5f };
            Console.WriteLine(flotante);
            double[] doble = { 18.789,1.3,2.5 };
            Console.WriteLine(doble);
            decimal[] conDecimales = { 1.23m,2.34m,3.45m};
            Console.WriteLine(conDecimales);
            // Arreglo de caracteres
            char[] caracter = { 'A', 'B', 'C' };
            Console.WriteLine(caracter);
            Console.WriteLine(caracter[0]);
            Console.WriteLine(caracter[1]);
            Console.WriteLine(caracter[2]);
            string cadena = new string(caracter);
            //caracter[3] =cadena[0];
            string[] nombre = { "A", "B", "C" };
            Console.WriteLine(cadena);
            bool[] boleano = { false, true, false };
            Console.WriteLine(boleano);
            DateTime[] fechaHora = { new DateTime(2020, 7, 10, 7, 10, 24), new DateTime(2021, 7, 10, 7, 10, 24), new DateTime(2022, 7, 10, 7, 10, 24) };
            Console.WriteLine(fechaHora);
            // Arreglo de dos dimensiones
            int[,] arreglo2D = new int[,] 
            { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 }, 
                { 7, 8 } 
            };
            // Arreglo de dos dimensiones con tamaño especificado
            int[,] arreglo2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // Arreglo de dos dimensiones con strings
            string[,] arreglo2Db = new string[3, 2] 
            { 
                { "uno", "dos" }, 
                { "tres", "cuatro" }, 
                { "cinco", "seis" } 
            };
            // Arreglo de tres dimensiones
            int[,,] arreglo3D = new int[,,] 
            { 
                { 
                  { 1, 2, 3 }, 
                  { 4, 5, 6 } 
                }, 
                { 
                  { 7, 8, 9 }, 
                  { 10, 11, 12 } 
                }                
            };
            // Acceso a los elementos
            System.Console.WriteLine(arreglo2D[0, 0]);
            System.Console.WriteLine(arreglo2D[0, 1]);
            System.Console.WriteLine(arreglo2Da[1, 0]);
            System.Console.WriteLine(arreglo2Da[1, 1]);
            System.Console.WriteLine(arreglo2Db[1, 0]);
            System.Console.WriteLine(arreglo3D[1, 0, 1]);
            System.Console.WriteLine(arreglo3D[1, 1, 2]);
        }
        public static void Enumeraciones()
        {
            byte num1;

            num1 = 3;

            Color oColor;

            oColor = Color.Azul;
       
            Console.WriteLine(oColor);

            ErrorCode error;
            error = ErrorCode.RegistroInexistente;

            Console.WriteLine(error);
            var b = (Color)1;
            Console.WriteLine(b);
            Color c = (Color)5;
            Console.WriteLine(c);
        }
        public static void Estructuras()
        {
            CoordenadaStruct oCoordenada = new CoordenadaStruct(2.4, 5.7);

            CoordenadaStruct oCoordenada1 = oCoordenada;
            oCoordenada1.X = 3;

            Console.WriteLine(oCoordenada.X);
            Console.WriteLine(oCoordenada.Y);
            Console.WriteLine(oCoordenada.Valores());
        }
    }

 
    /// <summary>
    /// Un tipo de enumeración es un tipo de valor definido por un conjunto de constantes con nombre 
    /// del tipo numérico integral subyacente. Para definir un tipo de enumeración, 
    /// use la palabra clave enum y especifique los nombres de miembros de enumeración:
    /// </summary>
    enum Color
    {
        Rojo,
        Verde,
        Azul,
        Amarillo,
        Cafe
    }
    enum ErrorCode : ushort
    {
        Ninguno = 0,
        Desconocido = 1,
        NoHayConexion = 100,
        RegistroInexistente = 200
    }

 

}
