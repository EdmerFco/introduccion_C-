using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Cadenas
    {
        public static void CadenaLiteral()
        {
            string cadena;
            string ruta = "c:\\Documentos\\DiplomadoNet";
            Console.WriteLine(ruta);

            ruta = @"c:\Documentos\DiplomadoNet";
            Console.WriteLine(ruta);

            cadena = ("En un string \\ es el caracter de escape: \n Nueva línea & \t Tabulador");
            Console.WriteLine(cadena);


            //Secuencia de escape Nombre de carácter  Codificación Unicode
            //\'	Comilla simple	0x0027
            //\"	Comilla doble	0x0022
            //\\	Barra diagonal inversa  0x005C
            //\0  Null    0x0000
            //\a Alerta  0x0007
            //\b Retroceso   0x0008
            //\f Avance de página    0x000C
            //\n Nueva línea 0x000A
            //\r Retorno de carro    0x000D
            //\t Tabulación horizontal   0x0009
            //\v Tabulación vertical 0x000B
            //\ a campana(alarma)
            //\ b retroceso
            //\ t tabulador
            //\ r retorno de carro
            //\ v tabulador vertical
            //\ f form feed - nueva página
            //\ n nueva línea
            //\ e escape
            //\ nnn Coincide con un carácter ASCII, donde nnn consta de dos o tres dígitos que representan el código de carácter octal. Por ejemplo, \ 040 representa un carácter de espacio.Esta construcción se interpreta como una referencia inversa si solo tiene un dígito(por ejemplo, \ 2) o si corresponde al número de un grupo de captura. (Consulte Construcciones de referencia inversa).
            //\ x nn Coincide con un carácter ASCII, donde nn es un código de carácter hexadecimal de dos dígitos.
            //\ c X Coincide con un carácter de control ASCII, donde X es la letra del carácter de control.Por ejemplo, \ cC es CTRL - C.
            //\ u nnnn Coincide con una unidad de código UTF - 16 cuyo valor es nnnn hexadecimal.Nota: .NET no admite el escape de caracteres de Perl 5 que se utiliza para especificar Unicode. El escape de caracteres de Perl 5 tiene la forma \ x {####…}, donde ####… es una serie de dígitos hexadecimales. En su lugar, use \ unnnn.
            cadena = (@"En un string \ es el caracter de escape: \n & \t");
            Console.WriteLine(cadena);
            string texto = @" Secuencias de Escape
            \a Alerta  0x0007
            \b Retroceso   0x0008
            \f Avance de página    0x000C
            \n Nueva línea 0x000A
            \r Retorno de carro    0x000D
            \t Tabulación horizontal   0x0009
            \v Tabulación vertical 0x000B";
            Console.WriteLine(texto);
    
            string quote = @"Estamos estudiando con ""TICH""";
            Console.WriteLine(quote);
        }
        public static void Concatenacion()
        {
            string tich = "TI - CAPITAL HUMANO, SA.de C.V.  (TICH) es una empresa dedicada" +
          "a brindar servicios de capacitación en las principales tecnologías de la información." +
          "Su oferta de formación se encuentra orientada al desarrollo profesional " +
          "de jóvenes con talento, principalmente del interior de la república, " +
          "buscando potenciar sus habilidades personales, mediante cursos de un alto nivel académico" +
          " y fuertemente enfocado en la rápida adaptación del alumno al ambiente laboral, " +
          " considerando que éste resulte productivo desde el primer día de trabajo.";

            Console.WriteLine(tich);

            string nombre = "Jorge";
            string primerApellido = "Valdivia";
            string segundoApellido = "Rosas";
            string nombreCompleto = nombre + " " + primerApellido + " " + segundoApellido;
            Console.WriteLine(nombreCompleto);
            nombre = nombre + " ";
            nombre += " ";
            nombre += primerApellido;
            nombre += " ";
            nombre += segundoApellido;
          Console.WriteLine(nombre);
        }
        public static void CadenasVaciasYNulas()
        {
            string cadena = "Hola";
            string cadenaNula = null;
            string cadenaVacia = String.Empty;
    
            string cadenaPaso = cadena + cadenaNula;
            Console.WriteLine(cadenaPaso);

            bool b = (cadenaVacia == cadenaNula);
            Console.WriteLine(b);

            string cadenaVaciaNula = cadenaVacia + cadenaNula;
            Console.WriteLine(cadenaVaciaNula);
            Console.WriteLine(cadenaVacia.Length);
            //Console.WriteLine(cadenaNula.Length);
            string s1 = "\x0" + "abc";
            string s2 = "abc" + "\x0";
             Console.WriteLine("*" + s1 + "*");
             Console.WriteLine("*" + s2 + "*");
             Console.WriteLine(s2.Length);

        }


        public static void FormatoCompuesto()
        {
            string nombre = "Jorge";
            string primerApellido = "Valdivia";
            string segundoApellido = "Rosas";
            int edad = 35;

            Console.WriteLine("{0} {1} {2} es el instructor y tiene {3} años de edad."
            , nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine("Hace {3} años nació {1} {2} {0}"
            , nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine("El nació en el año {0}.", 2021 - edad);

            String cadena;
            cadena = String.Format("{0} {1} {2} es el instructor y tiene {3} años de edad.", 
            nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine(cadena);
            cadena = String.Format("Hace {3} años nació {1} {2} {0}", 
            nombre, primerApellido, segundoApellido, edad);
            Console.WriteLine(cadena);
            cadena = String.Format("El nació en el año {0}.", 2021 - edad);
            Console.WriteLine(cadena);


            DateTime FechaNacimiento = new DateTime(1986,1,26,8,40,30);
            string s = String.Format("El nació el {0:d} a las {0:t}", FechaNacimiento);
            Console.WriteLine(s);

            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };
            var sb = new System.Text.StringBuilder();
            sb.Append(String.Format("{0,6} {1,15}\n\n", "Year", "Population"));
            for (int index = 0; index < years.Length; index++)
                sb.Append(String.Format("{0,6} {1,15:N0}\n", years[index], population[index]));

            Console.WriteLine(sb);

            int[] años = { 2013, 2014, 2015 };
            int[] poblacion = { 1025632, 1105967, 1148203 };
            String s1 = String.Format("{0,-10} {1,-10}\n\n", "Year", "Population");
            for (int index = 0; index < years.Length; index++)
                s1 += String.Format("{0,-10} {1,-10:N0}\n",
                                   años[index], poblacion[index]);
            Console.WriteLine($"\n{s1}");

            string[] palabras = { "Jorge", "Valdivia", "Rosas" };

            var fraseIlegible = string.Concat(palabras);
            System.Console.WriteLine(fraseIlegible);

            var fraseLegible = string.Join(" ", palabras);
            System.Console.WriteLine(fraseLegible);

        }

        public static void Concatenar()
        {
            string[] palabras = { "Jorge", "Valdivia", "Rosas" };

            var fraseIlegible = string.Concat(palabras);
            System.Console.WriteLine(fraseIlegible);

            var fraseLegible = string.Join(" ", palabras);
            System.Console.WriteLine(fraseLegible);

        }

        public static void ConstructorCadenas()
        {
            StringBuilder sb = new System.Text.StringBuilder("Gorge Valdivia Rosas");
            sb[0] = 'J';
            Console.WriteLine(sb);
            var sb1 = new StringBuilder();

            // Crea un string compuesta de los números del  0 - 9
            for (int i = 0; i < 10; i++)
            {
                sb1.Append(i.ToString());
            }
            Console.WriteLine(sb1);  

            // copiar un carácter del string (no es posible con  System.String)
            sb1[0] = sb1[9];

            Console.WriteLine(sb1);  


        }
        public static void Interpolacion()
        {
            string nombre = "Jorge";
            string primerApellido = "Valdivia";
            string segundoApellido = "Rosas";
            int edad = 35;
            String cadena;
            //Interpolación
            cadena = $"{nombre} {primerApellido} {segundoApellido} es el instructor y tiene {edad} años de edad.";
            Console.WriteLine(cadena);
            cadena = $"Hace {edad} años nació {primerApellido} {segundoApellido} {nombre}";
            Console.WriteLine(cadena);
            cadena = $"El nació en el año {2021 - edad}.";
            Console.WriteLine(cadena);

            Console.WriteLine($"{nombre} {primerApellido} {segundoApellido} es el instructor y tiene {edad} años de edad.");
            Console.WriteLine($"Hace {edad} años nació {primerApellido} {segundoApellido} {nombre}");
            Console.WriteLine($"El nació en el año {2021 - edad}.");
        }

        public static void Subcadenas()
        {
            string s3 = "Visual C# Express";
            Console.WriteLine(s3.Substring(7, 2));
            Console.WriteLine(s3.Replace("C#", "Basic"));
            int index = s3.IndexOf("C");
            Console.WriteLine(index);
        }

        public static void AccesoIndividual()
        {
            string s5 = "Jorge Valdivia";

            for (int i = 0; i < s5.Length; i++)
            {
                Console.Write(s5[s5.Length - i - 1]);
            }

        }
        public static void PropiedadesYMetodos()
        {
            string nombre = "Jorge Valdivia Rosas";
            Console.WriteLine(nombre.Length);
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.TrimEnd());
            Console.WriteLine(nombre.TrimStart());
            Console.WriteLine(nombre.Trim());
            Console.WriteLine(nombre.PadLeft(50));
            Console.WriteLine(nombre.PadLeft(50,'*'));
            Console.WriteLine(nombre.PadRight(50));
            Console.WriteLine(nombre.PadRight(50, '*'));
            Console.WriteLine(nombre.Substring(5,3));
            Console.WriteLine(nombre.Remove(5,5));
            Console.WriteLine(nombre.Replace("Jorge", "Ricardo"));
            Console.WriteLine(nombre);
            nombre = nombre.Replace("Jorge", "Ricardo");

            Console.WriteLine(nombre.IndexOf("Jorge",2));
            string otroNombre = nombre;
            Console.WriteLine(nombre.Equals(otroNombre));
            Console.WriteLine(nombre.CompareTo("Valdivia"));
            Console.WriteLine("Jorge".CompareTo("Jorge"));
            Console.WriteLine(nombre.Contains("Jorge"));
            nombre = nombre.Trim();
            Console.WriteLine(nombre.StartsWith("Jorge"));
            Console.WriteLine(nombre.EndsWith("Rosas"));
            nombre = "Jorge Valdivia Rosas";
            string[] partesNombre = nombre.Split(' ');
         

            Console.WriteLine(partesNombre[0]);
            Console.WriteLine(partesNombre[1]);
            Console.WriteLine(partesNombre[2]);
            char[] letras = nombre.ToCharArray();








            Console.WriteLine(letras[0]);
            Console.WriteLine(letras[1]);
            Console.WriteLine(letras[2]);
            Console.WriteLine(letras[3]);
            Console.WriteLine(letras[4]);
            
        }
  
    }
}
