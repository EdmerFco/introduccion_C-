using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Condicionales
    {
        public static void CondicionalIF()
        {
            string nombre = "Jorge";
            if (nombre.Equals("Jorge"))
                Console.WriteLine("La condición es verdadera");

            if (nombre.StartsWith("Jorge"))
                Console.WriteLine("La condición es verdadera");
            else
                Console.WriteLine("La condición es falsa");

            if (nombre.EndsWith("Rosas"))
            {
                Console.WriteLine("La condición es ...");
                Console.WriteLine("verdadera");
            }
            else
            {
                Console.WriteLine("La condición es...");
                Console.WriteLine("Falsa");
            }
            int a, b, c;
            a = 5;
            b = 5;
            c = 6;
            if (a == b)
                Console.WriteLine("{0} es igual a {1}",a,b);
            else
                Console.WriteLine("{0} diferente de {1}",a,b);
            if (a != b)
                Console.WriteLine("{0} diferente de {1}",a,b);
            else
                Console.WriteLine("{0} es igual {1}",1,b);
            if (c > a)
                Console.WriteLine("{0} es mayor {1} ",c,a);
            else
                Console.WriteLine("{0} NO es mayor {1}",c,a);
            if (b < c)
                Console.WriteLine("{0} es menor a {1} ", b, c);
            else
                Console.WriteLine("a {0} NO es mayor a {1}", b, c);
            if (a >= b)
                Console.WriteLine("{0} es mayor o igual a {1} ", a, b);
            else
                Console.WriteLine("{0} NO es mayor, NI igual a {1}, por lo tanto {a} es menor a {b}", a, b);
            if (a <= b)
                Console.WriteLine("{0} es menor o igual a {1} ", a, b);
            else
                Console.WriteLine("{0} NO es menor, NI igual a {1}, " +
                    ", por lo tanto {a} es mayor a {b}", a, b);

            a = 5;
            b = 3;
            if (a + b > 10)
                Console.WriteLine("a más b es mayor a 10");
            else
                Console.WriteLine("a más b es menor o igual a 10");
        }
        public static void OperadoresCondicionales()
        {

            //Operador de Negación !
            //Niega un Valor boleano
            bool boleano = true;
            boleano = !boleano;

            bool vboleano1 = true;
            bool vboleano2 = true;
            bool fboleano1 = false;
            bool fboleano2 = false;

            Console.WriteLine("Operador de Negación ! ");
            Console.WriteLine($"Operado vboleano1 = {vboleano1} ");
            Console.WriteLine($"Operado !vboleano1 = {!vboleano1} ");
            Console.WriteLine($"Operado fboleano1 = {fboleano1} ");
            Console.WriteLine($"Operado !fboleano1 = {!fboleano1} ");
            Console.ReadKey();
            Console.WriteLine("Operador lógico AND (Y) &");
            //Operador lógico AND (Y) & -> siempre se evaluan los dos operandos
            if (vboleano1 & vboleano2)
                Console.WriteLine($"{vboleano1} Y {vboleano2} => ({vboleano1 & vboleano2}) ");
            else
                Console.WriteLine($"{vboleano1} Y {vboleano2} => ({vboleano1 & vboleano2}) ");
    
            Console.WriteLine("Tabla de verdad operador AND (Y) &");

            Console.WriteLine($"{vboleano1} Y {vboleano2} => ({vboleano1 & vboleano2} ) ");
            Console.WriteLine($"{vboleano1} Y {fboleano2} => ({vboleano1 & fboleano2} ) ");
            Console.WriteLine($"{fboleano1} Y {vboleano2} => ({fboleano1 & vboleano2} ) ");
            Console.WriteLine($"{fboleano1} Y {fboleano2} => ({fboleano1 & fboleano2} ) ");
            Console.ReadKey();
            //
            //El operador & evalúa ambos operandos, incluso aunque
            //el izquierdo se evalúe como falso, 
            //para que el resultado de la operación sea falso 
            //con independencia del valor del operando derecho.
            bool r = EvaluaPrimerOperando() & EvaluaSecondoOperando();


            bool f = false & EvaluaSecondoOperando();
            bool b = true & EvaluaSecondoOperando();
            Console.WriteLine(b);
            Console.ReadKey();
            //Operador AND lógico condicional &&");
            //El operador AND lógico condicional &&, 
            //también denominado operador AND lógico de cortocircuito,
            //
            //El resultado de (boleano1 && boleano2 ) es verdadero
            //si boleano1 y boleano2 son verdaderos. 
            //De lo contrario, el resultado es falso. 
            //Si boleano1 se evalúa como falso, boleano1 ya NO SE EVALÚA
            //porque independientemente de su valor el resultado será falso");

            r = EvaluaPrimerOperando() && EvaluaSecondoOperando();

            r = false && EvaluaSecondoOperando();
            Console.WriteLine(r);
            b = true && EvaluaSecondoOperando();
            Console.WriteLine(b);
            Console.ReadKey();
            Console.WriteLine("Operador AND lógico condicional &&");
            Console.WriteLine(@"El operador AND lógico condicional &&, 
                también denominado operador AND lógico de cortocircuito,
                calcula el operador AND lógico de sus operandos. 
                El resultado de x && y es true si x y y se evalúan como true. 
                De lo contrario, el resultado es false. 
                Si x se evalúa como false, y NO SE EVALÚA");
            r = false && EvaluaSecondoOperando();
            Console.WriteLine(r);
            b = true && EvaluaSecondoOperando();
            Console.WriteLine(b);

            Console.ReadKey();
            Console.WriteLine("Operador lógico OR (O) |");

            if (vboleano1 | vboleano2)
                Console.WriteLine($"{vboleano1} Ó {vboleano2} => ({vboleano1 | vboleano2}) ");
            else
                Console.WriteLine($"{vboleano1} Ó {vboleano2} => ({vboleano1 | vboleano2}) ");

            Console.WriteLine("Tabla de verdad operador OR (O) |");

            Console.WriteLine($"{vboleano1} Ó {vboleano2} => ({vboleano1 | vboleano2} ) ");
            Console.WriteLine($"{vboleano1} Ó {fboleano2} => ({vboleano1 | fboleano2} ) ");
            Console.WriteLine($"{fboleano1} Ó {vboleano2} => ({fboleano1 | vboleano2} ) ");
            Console.WriteLine($"{fboleano1} Ó {fboleano2} => ({fboleano1 | fboleano2} ) ");
            Console.ReadKey();
            // Operador lógico OR (O) |
            //El operador | siempre evalúa ambos operandos, 
            //incluso aunque el izquierdo se evalúe como falso, 
            r = EvaluaPrimerOperando() | EvaluaSecondoOperando();
            r = false | EvaluaSecondoOperando();
            b = true | EvaluaSecondoOperando();
            Console.WriteLine(b);
            Console.ReadKey();
            Console.WriteLine("Operador OR lógico condicional ||");
            Console.WriteLine(@"El operador OR lógico condicional ||, 
                también denominado operador OR lógico de cortocircuito,
                calcula el operador OR lógico de sus operandos. 
                El resultado de x || y es VERDADERO si x Ó y se evalúan como VERDADERO. 
                De lo contrario, el resultado es FALSO. 
                Si x se evalúa como VERDADERO, y NO SE EVALÚA");
            r = false || EvaluaSecondoOperando();
            Console.WriteLine(r);
            b = true || EvaluaSecondoOperando();
            Console.WriteLine(b);
            Console.ReadKey();

            Console.WriteLine("Operador lógico OR EXCLUSIVO (XOR) ^");
            Console.WriteLine(@"El operador OR ^, 
                también denominado operador OR lógico de exclusivo,
                El resultado de x ^ y es VERDADERO si x Ó y se evalúan como VERDADERO, 
                pero no ambos. 
                De lo contrario, el resultado es FALSO. ");
    
            if (vboleano1 ^ vboleano2)
                Console.WriteLine($"{vboleano1} Ó exclusivo {vboleano2} => ({vboleano1 ^ vboleano2}) ");
            else
                Console.WriteLine($"{vboleano1} Ó exclusivo {vboleano2} => ({vboleano1 ^ vboleano2}) ");

            Console.WriteLine("Tabla de verdad operador OR (O) ^");

            Console.WriteLine($"{vboleano1} Ó exclusivo {vboleano2} => ({vboleano1 ^ vboleano2} ) ");
            Console.WriteLine($"{vboleano1} Ó exclusivo {fboleano2} => ({vboleano1 ^ fboleano2} ) ");
            Console.WriteLine($"{fboleano1} Ó exclusivo {vboleano2} => ({fboleano1 ^ vboleano2} ) ");
            Console.WriteLine($"{fboleano1} Ó exclusivo {fboleano2} => ({fboleano1 ^ fboleano2} ) ");
            Console.ReadKey();
            int a1 = 5;
            int b1 = 3;
            int c1 = 4;
            if ((a1 + b1 + c1 > 10) && (a1 == b1))
            {
                Console.WriteLine("La suma es mayor a 10");
                Console.WriteLine("y el primer número es igual al segundo");
            }
            else
            {
                Console.WriteLine("La suma NO es mayor a 10");
                Console.WriteLine("O el primer número NO es igual al segundo");
            }

            if ((a1 + b1 + c1 > 10) || (a1 == b1))
            {
                Console.WriteLine("La suma es mayor a 10");
                Console.WriteLine("O el primer número es igual al segundo");
            }
            else
            {
                Console.WriteLine("La suma NO es mayor a 10");
                Console.WriteLine("Y el primer número NO es igual al segundo");
            }

        }
        private static bool EvaluaSecondoOperando()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        private static bool EvaluaPrimerOperando()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        public static void CondicionalSwitch()
        {
            int caseSwitch = 1;

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Color c = (Color)3;
            switch (c)
            {
                case Color.Rojo:
                    Console.WriteLine("El color es Rojo");
                    break;
                case Color.Verde:
                    Console.WriteLine("El color es Verde");
                    break;
                case Color.Azul:
                    Console.WriteLine("El color es Azul");
                    break;
                default:
                    Console.WriteLine("El color es desconocido.");
                    break;
            }
            if (c == Color.Rojo)
                Console.WriteLine("El color es Rojo");
            else if (c == Color.Verde)
                Console.WriteLine("El color es Verde");
            else if (c == Color.Azul)
                Console.WriteLine("El color es Azul");
            else
                Console.WriteLine("El color es desconocido.");

            string caseSwitchCadena = "Dos";
            switch (caseSwitchCadena)
            {
                case "Uno":
                    Console.WriteLine("Case Uno");
                    break;
                case "Dos":
                case "Tres":
                    Console.WriteLine($"Case {caseSwitchCadena}");
                    break;
                default:
                    Console.WriteLine($"Un valor inesperado ({caseSwitch})");
                    break;
            }

        }
        public static void OperadorCondicionalTerniario() {
            Console.WriteLine(@"El operador condicional ?:, también conocido como operador condicional ternario, 
                                evalúa una expresión booleana y devuelve el resultado de una de las dos expresiones,
en función de que la expresión booleana se evalúe como true o false, 
tal y como se muestra en el siguiente ejemplo:");

            Console.WriteLine("sintaxis \n condition ? consequent : alternative");
            decimal temperatura = 14.5m;
            string resultado = temperatura < 20.0m ? "Frio" : "Caluroso!";
            Console.WriteLine(resultado);
            if (temperatura < 20.0m) 
            {
                resultado = "Frio";
            }
            else
            { 
                resultado = "Caluroso!"; 
            }
 
            Console.WriteLine(resultado);
            temperatura = 24.5m;
            resultado = temperatura < 20.0m ? "Frio" : "Caluroso!";
            Console.WriteLine(resultado);
            temperatura = 22.5m;
            resultado = temperatura < 20.0m ? "Frio" : temperatura < 23.0m ? "Perfecto" : "Caluroso!";
            Console.WriteLine(resultado);
            resultado = temperatura < 20.0m ? "Frio" : (temperatura < 23.0m ? "Perfecto" : "Caluroso!");
            Console.WriteLine(resultado);
            if (temperatura < 20.0m)
            {
                resultado = "Frio";
            }
            else
            {
                if (temperatura < 23.0m)
                {
                    resultado = "Perfecto";
                }
                else
                {
                    resultado = "Caluroso!";
                }
            }
            Console.WriteLine(resultado);

        }
    
       public static void OperadorUsoCombinadoNull()
        {
            Console.WriteLine(@"El operador de uso combinado de NULL ?? 
devuelve el valor del operando izquierdo si no es null; en caso contrario, 
evalúa el operando derecho y devuelve su resultado. 
El operador ?? no evalúa su operando derecho si el operando izquierdo se evalúa como no NULL.");
            int? a = null;

            int? b = a ?? 5;
            Console.WriteLine(b);
            int? c = b ?? 10;
            Console.WriteLine(c);
        }

    public enum Color { Rojo, Verde, Azul }
    }
}
