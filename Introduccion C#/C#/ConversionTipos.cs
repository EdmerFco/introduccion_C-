using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class ConversionTipos
    {
        public static void ConversionEntero()
        {
            string snum = "1234";
            int num;
            num = Convert.ToInt32(snum);
            Console.WriteLine(num);
        }
            
        public static void Conversiones()
        {
            // Conversión Implicita.

            //byte a = 13;
            //byte b = 300;  // CS0031: El valor constante '300' no puede ser converetido a 'byte'

            // Una variable long puede contener un valor de un int
            int num = 2147483647;
            long bigNum = num;
            
            Console.WriteLine($"num {num} bigNum {bigNum}");
            //num = bigNum; //Error un long no se puede convertir implícitamente en int
            // Conversión Explicita.
            num = (int)bigNum;
            string snum = "2147483647";
            //num = snum;
            num = int.Parse(snum);

            num = Convert.ToInt32(snum);

            bool valido;
            valido = int.TryParse(snum, out num);

            snum = "mil quinientos";
            //num = snum;
            valido = int.TryParse(snum, out num);
            try
            {
                num = int.Parse(snum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string sfecha = "2021-06-01";
            DateTime fecha;
            fecha = DateTime.Parse(sfecha);
            fecha = Convert.ToDateTime(sfecha);
            valido = DateTime.TryParse(sfecha, out fecha);
            sfecha = "2021-06-03";
            valido = DateTime.TryParse(sfecha, out fecha);

            try
            {
                fecha = DateTime.Parse(sfecha);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            fecha = DateTime.Parse(sfecha);
            fecha = Convert.ToDateTime(sfecha);

            //Conversión Implicita entre Tipos definidos por el usuario
            //Para ello se requiere que el tipo destino sea una clase base del tipo orígen
            Empleado empleado = new Empleado("Jorge Empleado","Valdivia",new DateTime(1978,10,02));
            Directivo directivo = new Directivo("Jorge Directivo", "Valdivia", new DateTime(1978, 10, 02));
         
            Console.WriteLine("Antes de Convertir Explicitamente");
            Console.WriteLine($"Empleado nombre: {empleado.nombre} " +
                $"apellidos {empleado.apellidos} " +
                $"fechaNacimiento {empleado.fechaNacimiento}");
            Console.WriteLine($"Directivo nombre: {directivo.nombre} " +
                $"apellidos {directivo.apellidos} " +
                $"fechaNacimiento {directivo.fechaNacimiento}");
            empleado = directivo;

            Console.WriteLine("Despues de Convertir Implicitamente");
            Console.WriteLine($"Empleado nombre: {empleado.nombre} " +
                $"apellidos {empleado.apellidos} " +
                $"fechaNacimiento {empleado.fechaNacimiento}");
            Console.WriteLine($"Directivo nombre: {directivo.nombre} apellidos {directivo.apellidos} fechaNacimiento {directivo.fechaNacimiento}");
            
            //directivo = empleado;
            directivo = (Directivo)empleado;

            //El  operador as convierte explícitamente el resultado de una expresión en una referencia
            //determinada o un tipo de valor que acepta valores NULL.
            //Si la conversión no es posible, el asoperador regresa null.
            //A diferencia de una expresión de conversión, el operador as nunca lanza una excepción.
            directivo = empleado as Directivo;

            Console.WriteLine("Despues de Convertir Explicitamete");
            Console.WriteLine($"Empleado nombre: {empleado.nombre} " +
                $"apellidos {empleado.apellidos} " +
                $"fechaNacimiento {empleado.fechaNacimiento}");
            Console.WriteLine($"Directivo nombre: {directivo.nombre} " +
                $"apellidos {directivo.apellidos} " +
                $"fechaNacimiento {directivo.fechaNacimiento}");
            

        }
    }
}
