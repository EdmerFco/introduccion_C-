using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Ciclos
    {
        /// <summary>
        /// La instrucción while comprueba una condición y ejecuta la instrucción o el bloque de instrucciones 
        /// que aparece después de while. 
        /// La comprobación de la condición y la ejecución de dichas instrucciones se repetirán hasta que la condición sea falsa.
        /// </summary>
        public static void Mientras()
        {
            int contador = 1;
            while (contador < 6)
            {
                Console.WriteLine($"Hola Mundo! El contador es {contador}");
                contador++;
            }

        }
        /// <summary>

        /// </summary>
        public static void HacerMientras()
        {
            int contador = 10;
            do
            {
                Console.WriteLine($"Hola Mundo! El contador es {contador}");
                contador++;
            } while (contador < 16);

        }
        /// <summary>
        ///  La instrucción for funciona de la misma forma que los bucles while y do
        ///  La instrucción for consta de tres partes que controlan su funcionamiento.
        ///  Con base en el siguiente ejemplo:
        ///  La primera parte es el inicializador de for: int contador = 0; declara que contador 
        ///  es la variable de bucle y establece su valor inicial en 0.
        ///  La parte central es la condición de for: contador< 10 declara que este bucle for debe continuar ejecutándose 
        ///  mientras que el valor del contador sea menor que diez.
        ///  La última parte es el iterador de for: contador++ 
        ///  especifica cómo modificar la variable de bucle después de ejecutar el bloque que sigue a la instrucción for. 
        ///  En este caso, especifica que contador debe incrementarse en uno cada vez que el bloque se ejecuta.
        /// </summary>
        public static void Para()
        {

            for (int contador = 0; contador < 6; contador++)
            {
                Console.WriteLine($"Hola Mundo! El contador es {contador}");
            }



            int[,] arreglo2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"arreglo2D({i},{j}): {arreglo2D[i, j]}");
                }
            }

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"arreglo2D({i},{j}): {arreglo2D[i, j]}");
                }
            }

        }

        /// <summary>
        /// La instrucción foreach ejecuta una declaración o un bloque de declaraciones 
        /// para cada elemento en una instancia del tipo que implementa la interfaz System.Collections.IEnumerable o
        /// System.Collections.Generic.IEnumerable <T>
        /// </summary>
        public static void PorCadaUno()
        {

            int[] arregloNumeros = { 1, 2, 3, 4, 5 };
            foreach (int i in arregloNumeros)
            {
                Console.WriteLine($"Elemento: {i} ");
            }

        }
        public static void ParaAnidados()
        {
            int[,] arreglo2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // Arreglo de dos dimensiones con strings
            string[,] arreglo2Db = new string[2, 3] { { "uno", "dos", "tres" }, { "cuatro", "cinco", "seis" } };
            // Arreglo de tres dimensiones
            int[,,] arreglo3D = new int[3, 2, 4]
            {
                {
                    { 1, 2, 3, 4 },
                    { 5, 6, 7, 8 }
                },
                {
                    { 9, 10, 11, 12 },
                    { 13, 14, 15, 16 }
                },
                {
                    { 17, 18, 19, 20 },
                    { 21, 22, 23, 24 }
                }
            };
            // Acceso a los elementos

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine(arreglo2Da[i, j]);
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    System.Console.WriteLine(arreglo2Db[i, j]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        System.Console.WriteLine(arreglo3D[i, j, k]);
                    }
                }
            }



        }
      
        public static void TablaISR()
        {
            decimal[,] tabISR = new decimal[,]
            {
                {0.01m,285.45m,0m,1.92m,200.85m},
                {285.46m,872.85m,5.55m,6.4m,200.85m},
                {872.86m,1309.2m,5.55m,6.4m,200.7m},
                {1309.21m,1713.6m,5.55m,6.4m,200.7m},
                {1713.61m,1745.7m,5.55m,6.4m,193.8m},
                {1745.71m,2193.75m,5.55m,6.4m,188.7m},
                {2193.76m,2327.55m,5.55m,6.4m,174.75m},
                {2327.56m,2422.8m,5.55m,6.4m,160.35m},
                {2422.81m,2632.65m,142.2m,10.88m,160.35m},
                {2632.66m,3071.4m,142.2m,10.88m,145.35m},
                {3071.41m,3510.15m,142.2m,10.88m,125.1m},
                {3510.16m,3642.6m,142.2m,10.88m,107.4m},
                {3642.61m,4257.9m,142.2m,10.88m,0m},
                {4257.91m,4949.55m,341.85m,16m,0m},
                {4949.56m,5925.9m,452.55m,17.92m,0m},
                {5925.91m,11951.85m,627.6m,21.36m,0m},
                {11951.86m,18837.75m,1914.75m,23.52m,0m},
                {18837.76m,35964.3m,3534.3m,30m,0m},
                {35964.31m,47952.3m,8672.25m,32m,0m},
                {47952.31m,143856.9m,12508.35m,34m,0m},
                {143856.91m,99999999m,45115.95m,35m,0m}
            };
            StringBuilder a = new StringBuilder();

            int rango = tabISR.Rank;
            Console.WriteLine($"Rango de la Tabla: {rango}");
            int rens = tabISR.GetUpperBound(0);
            Console.WriteLine($"Renglones de la Tabla: {rens}");
            int cols = tabISR.GetUpperBound(1);
            Console.WriteLine($"Columnas de la Tabla: {cols}");
            for (int i = 0; i <= rens; i++)
            {
                for (int j = 0; j <= cols; j++)
                {
                    Console.WriteLine(tabISR[i, j]);
                }
            }

        }


    }
}
}
