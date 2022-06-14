using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Operaciones
    {
        public static void numeros()
        {
            int entero1, entero2,rentero;
            float flotante1, flotante2,rflotante;
            decimal decimal1, decimal2,rdecimal;
            entero1 = 5;
            entero2 = 2;
            flotante1 = 5.5f;
            flotante2 = 2.5f;
            decimal1 = 5.5m;
            decimal2 = 2.5m;
            Console.WriteLine("Operador de suma +");
            rentero = entero1 + entero2;
            rflotante = flotante1 + flotante2;
            rdecimal = decimal1 + decimal2;
            Console.WriteLine(rentero); 
            Console.WriteLine(rflotante);
            Console.WriteLine(rdecimal);
            Console.ReadKey();
            Console.WriteLine("Operador de resta -");
            rentero = entero1 - entero2;
            rflotante = flotante1 - flotante2;
            rdecimal = decimal1 - decimal2;
            Console.WriteLine(rentero);
            Console.WriteLine(rflotante);
            Console.WriteLine(rdecimal);
            Console.ReadKey();
            Console.WriteLine("Operador de multiplicacion *");
            rentero = entero1 * entero2;
            rflotante = flotante1 * flotante2;
            rdecimal = decimal1 * decimal2;
            Console.WriteLine(rentero);
            Console.WriteLine(rflotante);
            Console.WriteLine(rdecimal);
            Console.ReadKey();
            Console.WriteLine("Operador de división /");
            rentero = entero1 / entero2;
            rflotante = flotante1 / flotante2;
            rdecimal = decimal1 / decimal2;
            Console.WriteLine(rentero);
            Console.WriteLine(rflotante);
            Console.WriteLine(rdecimal);
            Console.ReadKey();
            Console.WriteLine("Operador Residuo %");
            rentero = entero1 % entero2;
            rflotante = flotante1 % flotante2;
            rdecimal = decimal1 % decimal2;
            Console.WriteLine(rentero);
            Console.WriteLine(rflotante);
            Console.WriteLine(rdecimal);
            Console.ReadKey();
            Console.WriteLine("Operador unario menos -");
            Console.WriteLine(-entero1);  
            Console.WriteLine(-(-entero1));
            Console.ReadKey();
            Console.WriteLine("Operador de incremento prefijo");
            entero1 = 5;
            Console.WriteLine(entero1);  
            Console.WriteLine(++entero1); 
            Console.WriteLine(entero1);
            Console.ReadKey();
            Console.WriteLine("Operador de incremento sufijo");
            entero1 = 5;
            Console.WriteLine(entero1);
            Console.WriteLine(entero1++);
            Console.WriteLine(entero1);
            Console.WriteLine("Operador de decremento prefijo");
            entero1 = 5;
            Console.WriteLine(entero1); 
            Console.WriteLine(--entero1); 
            Console.WriteLine(entero1);
            Console.ReadKey();
            Console.WriteLine("Operador de decremento sufijo");
            entero1 = 5;
            Console.WriteLine(entero1); 
            Console.WriteLine(entero1--); 
            Console.WriteLine(entero1); 
            Console.ReadKey();
            Console.WriteLine("Asignación Compuesta");
            entero1 = 5;           
            entero1 += 9;
            Console.WriteLine(entero1);
            entero1 -= 4;
            Console.WriteLine(entero1);
            entero1 *= 2;
            Console.WriteLine(entero1);
            entero1 /= 4;
            Console.WriteLine(entero1);
            entero1 %= 3;
            Console.WriteLine(entero1);
        }
        public static void numerosManual()
        {
            int i = 3;
            Console.WriteLine(i);   // salida: 3
            Console.WriteLine(i++); // salida: 3
            Console.WriteLine(i);   // salida: 4
            
            //Operador de incremento prefijo
            //El resultado de++x es el valor de xdespués de la operación,
            //tal y como se muestra en el ejemplo siguiente:
            double a = 1.5;
            Console.WriteLine(a);   // salida: 1.5
            Console.WriteLine(++a); // salida: 2.5
            Console.WriteLine(a);   // salida: 2.5

            //Operador de decremento de prefijo
            //El resultado de --x es el valor de xdespués de la operación,
            //tal y como se muestra en el ejemplo siguiente:
            double a1 = 1.5;
            Console.WriteLine(a1);   // salida:1.5
            Console.WriteLine(--a1); // salida:0.5
            Console.WriteLine(a);   // salida:0.5
           
            //Operadores unarios más y menos
            //El operador + unario devuelve el valor de su operando.
            //El operador unario - calcula la negación numérica del operando.
            Console.WriteLine(+4);     // salida:4
            Console.WriteLine(-4);     // salida:-4
            Console.WriteLine(-(-4));  // salida:4

            uint a2 = 5;
            var b = -a2;
            Console.WriteLine(b);            // salida:-5
            Console.WriteLine(b.GetType());  // salida:System.Int64

            Console.WriteLine(-double.NaN);  // salida:NaN


            //Operador de multiplicación*
            //El operador de multiplicación* calcula el producto de sus operandos:
            Console.WriteLine(5 * 2);         // salida: 10
            Console.WriteLine(0.5 * 2.5);     // salida: 1.25
            Console.WriteLine(0.1m * 23.4m);  // salida: 2.34


            //Operador de división /
            //El operador de división / divide el operando izquierdo entre el derecho.
            //División de enteros
            //Para los operandos de tipos enteros, el resultado del operador /
            //es de un tipo entero y equivale al cociente de los dos operandos
            //redondeados hacia cero:
            Console.WriteLine(13 / 5);    // salida: 2
            Console.WriteLine(-13 / 5);   // salida: -2
            Console.WriteLine(13 / -5);   // salida: -2
            Console.WriteLine(-13 / -5);  // salida: 2

            //Para obtener el cociente de los dos operandos como número de punto flotante,
            //use el tipo float, double o decimal:

            Console.WriteLine(13 / 5.0);       // salida: 2.6

            int a3 = 13;
            int b3 = 5;
            Console.WriteLine((double)a3 / b3);  // salida: 2.6

            //División de punto flotante
            //Para los tipos float, double y decimal, el resultado del operador / es el cociente de los dos operandos:

            Console.WriteLine(16.8f / 4.1f);   // salida: 4.097561
            Console.WriteLine(16.8d / 4.1d);   // salida: 4.09756097560976
            Console.WriteLine(16.8m / 4.1m);   // salida: 4.0975609756097560975609756098
            
            
            //Operador de Residuo %
            //El operador de Residuo % calcula el Residuo
            //después de dividir el operando izquierdo entre el derecho.
            //Residuo entero
            //En el caso de los operandos de tipos enteros,
            //el resultado de a % b es el valor producido por a -(a / b) * b.
            //El signo de resto distinto de cero es el mismo que el del operando izquierdo,
            //como se muestra en el ejemplo siguiente:
            Console.WriteLine(5 % 4);   // salida: 1
            Console.WriteLine(5 % -4);  // salida: 1
            Console.WriteLine(-5 % 4);  // salida: -1
            Console.WriteLine(-5 % -4); // salida: -1



        }
        public static void cadenas()
        {

            string tich = "TI - CAPITAL HUMANO, SA.de C.V.  (TICH) es una empresa dedicada" +
                "a brindar servicios de capacitación en las principales tecnologías de la información." +
                "Su oferta de formación se encuentra orientada al desarrollo profesional " +
                "de jóvenes con talento, principalmente del interior de la república, " +
                "buscando potenciar sus habilidades personales, mediante cursos de un alto nivel académico" + 
                " y fuertemente enfocado en la rápida adaptación del alumno al ambiente laboral, " + 
                " considerando que éste resulte productivo desde el primer día de trabajo.";

            string nombre = "Jorge";
            string primerApellido = "Valdivia";
            string segundoApellido = "Rosas";

            string nombreCompleto = nombre + " " + primerApellido + " " + segundoApellido;


            nombre = nombre + " ";
            nombre += " ";
            nombre += primerApellido;
            nombre += " ";
            nombre += segundoApellido;

            
            Console.WriteLine(tich);

            Console.WriteLine(nombreCompleto);

            Console.WriteLine(nombre);

            string s5 = "Printing backwards";

            for (int i = 0; i < s5.Length; i++)
            {
                Console.Write(s5[s5.Length - i - 1]);
            }

        }
    }
}
