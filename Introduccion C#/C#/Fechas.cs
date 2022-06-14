using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Fechas
    {
        public static void Asignacion()
        {
            // Fecha Vacia   
            DateTime fechaVacia = new DateTime();
            Console.WriteLine(fechaVacia.ToString());
            // Fecha y Hora 
            DateTime fechaHora = new DateTime(2021, 1, 1, 8, 30, 52);
            Console.WriteLine(fechaHora);
            // Solo fecha
            DateTime soloFecha = new DateTime(2002, 10, 18);
            Console.WriteLine(soloFecha.ToString());
            // Fecha con milisegundos 
            DateTime fechaConMilisegundos = new DateTime(2021, 1, 1, 5, 30, 45, 100);
            Console.WriteLine(fechaConMilisegundos.ToString());
            // Solo Hora 
            DateTime horaSolo = new DateTime(10000000);
            Console.WriteLine(horaSolo.ToString());
            // Fecha con localización
            DateTime fechaClase = new DateTime(2021, 1, 10, 7, 10, 24, DateTimeKind.Local);
            // Crear fecha desde string  
            string fechaString = "7/10/2021 7:10:24 AM";
            DateTime fechaDesdeString = DateTime.Parse(fechaString, CultureInfo.InvariantCulture);
            Console.WriteLine(fechaDesdeString.ToString());
            //string dt = "2010-10-04T20:12:45:00";
            //DateTime newDt = DateTime.Parse(dt, CultureInfo.InvariantCulture);
            //Console.WriteLine(newDt.ToString());
        }

        public static void Propiedades()
        {
            DateTime fecha = new DateTime(2021, 7, 10, 7, 10, 24);
            Console.WriteLine("Dia:{0}", fecha.Day);
            Console.WriteLine("Mes:{0}", fecha.Month);
            Console.WriteLine("Año:{0}", fecha.Year);
            Console.WriteLine("Hora:{0}", fecha.Hour);
            Console.WriteLine("Minuto:{0}", fecha.Minute);
            Console.WriteLine("Secondo:{0}", fecha.Second);
            Console.WriteLine("Milisecondo:{0}", fecha.Millisecond);
            Console.WriteLine("Día de la semana:{0}", fecha.DayOfWeek);
            Console.WriteLine("Día del año {0}", fecha.DayOfYear);
            Console.WriteLine("Hora del día:{0}", fecha.TimeOfDay);
            Console.WriteLine("Tick:{0}", fecha.Ticks);

        }
        public static void Metodos()
        {
            // Adiciona y resta 30 días de la fecha actual
            DateTime fecha = DateTime.Now;
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha);
            TimeSpan unMes = new TimeSpan(30, 0, 0, 1);
            DateTime diaDespuesMes = fecha.Add(unMes);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", diaDespuesMes);
            DateTime diaAntesMes = fecha.Subtract(unMes);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", diaAntesMes);
            // Adiciona Años  
            fecha = DateTime.Now;
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha);
            Console.WriteLine(fecha.ToString(System.Globalization.CultureInfo.InvariantCulture));
            // Adiciona Años  
            fecha = fecha.AddYears(2);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha.AddYears(2));
            // Adiciona Años  
            fecha = fecha.AddYears(-2);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha.AddYears(-2));
            // Adiciona Meses  
            fecha = fecha.AddMonths(2);
            Console.WriteLine(fecha.AddMonths(2));
            // Adiciona días  
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha.AddDays(12));
            // Adiciona horas  
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha.AddHours(4.25));
            // Adiciona minutos  
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha.AddMinutes(15));
            // Adiciona segundos  
            fecha.AddSeconds(45);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha);
            // Adiciona milisegundos  
            fecha.AddMilliseconds(200);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha);
            // Adiciona Ticks  
            fecha.AddTicks(5000);
            Console.WriteLine("{0:yyyy/MM/dd hh:mm:ss}", fecha);
            fecha = new DateTime(2000, 10, 20, 12, 15, 45);
            DateTime fechaSub = new DateTime(2000, 2, 6, 13, 5, 15);
            // Resta una fecha 
            TimeSpan fechaDiff = fecha.Subtract(fechaSub);
            Console.WriteLine(fechaDiff.ToString());
            // TimeSpan con 10 dias, 2 hrs, 30 mins, 45 secondos, and 100 milisecondos  
            TimeSpan ts = new TimeSpan(10, 2, 30, 45, 100);
            // Resta un TimeSpan  
            DateTime diff2 = fecha.Subtract(ts);        
            Console.WriteLine(diff2.ToString());
            // Resta 10 dias  
            DateTime fechaResta = new DateTime(fecha.Year, fecha.Month, fecha.Day - 10);
            Console.WriteLine(fechaResta.ToString());
            // Resta horas, minutos, y secondos  
            DateTime hms = new DateTime(fecha.Year, fecha.Month, fecha.Day, fecha.Hour - 1, fecha.Minute - 15, fecha.Second - 15);
            Console.WriteLine(hms.ToString());
            Console.WriteLine("Obtener fechas de un mes");
            // Obtener días de un mes  
            int dias = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine(dias);
            DateTime dob = new DateTime(2002, 10, 22);
            //Horario de Verano
            Console.WriteLine(dob.IsDaylightSavingTime());
            // Año Bisiesto
            Console.WriteLine(DateTime.IsLeapYear(dob.Year));
        }

        public static void Comparacion()
        {
            DateTime primeraFecha = new DateTime(2021, 8, 11);
            DateTime segundaFecha = new DateTime(2019, 8, 11);
            int result = DateTime.Compare(primeraFecha, segundaFecha);

            if (result < 0)
                Console.WriteLine("La primera fecha es más antigua");
            else if (result == 0)
                Console.WriteLine("Ambas fechas son iguales");
            else
                Console.WriteLine("La primer fecha es mas reciente");
            int compareResult = primeraFecha.CompareTo(segundaFecha);
            if (compareResult < 0)
                Console.WriteLine("La primera fecha es más antigua");
            else if (compareResult == 0)
                Console.WriteLine("Ambas fechas son iguales");
            else
                Console.WriteLine("La primer fecha es mas reciente");

        }

        public static void FormatearToString()
        {
            DateTime fecha = new DateTime(2021, 1, 1, 8, 30, 52);
            DateTime aDate = DateTime.Now;
            //d -> Representa el día del mes como un número del 1 al 31.
            //dd->Representa el día del mes como un número del 01 al 31.
            //ddd->Representa el nombre abreviado del día(lunes, martes, miércoles, etc.).
            //dddd->Representa el nombre completo del día(lunes, martes, etc.).
            //h->hora del reloj de 12 horas(por ejemplo, 4).
            //hh->reloj de 12 horas, con un 0 inicial(p.ej., 06)
            //H->hora del reloj de 24 horas(por ejemplo, 15)
            //HH->hora de reloj de 24 horas, con un 0 inicial(por ejemplo, 22)
            //m->Minutos
            //mm->Minutos con cero a la izquierda
            //M->Número de mes(por ejemplo, 3)
            //MM->Número de mes con cero a la izquierda(por ejemplo, 04)
            //MMM->Nombre abreviado del mes(por ejemplo, diciembre)
            //MMMM->Nombre del mes completo(por ejemplo, diciembre)
            //s->Segundos
            //ss->Segundos con cero a la izquierda
            //t->Abreviado AM / PM(por ejemplo, A o P)
            //tt->AM / PM(p.ej., AM o PM
            //y->Año, sin cero a la izquierda(por ejemplo, 2015 sería 15)
            //aa->Año, cero a la izquierda(por ejemplo, 2015 sería 015)
            //aaa->Año, (p.ej., 2015)
            //aaaa->Año, (p.ej., 2015)
            //K->Representa la información de la zona horaria de un valor de fecha y hora(por ejemplo, +05: 00)
            //z->Con valores DateTime representa el desplazamiento firmado de la zona horaria del sistema operativo local desde
            //Hora universal coordinada(UTC), medida en horas. (por ejemplo, +6)
            //zz->Como z, pero con cero a la izquierda(por ejemplo, +06)
            //zzz->Con valores DateTime representa el desplazamiento firmado de la zona horaria del
            //sistema operativo local con respecto a UTC, medido en horas y minutos. (por ejemplo, +06: 00)
            //f->Representa el dígito más significativo de la fracción de segundos; es decir,
            //representa las décimas de segundo en un valor de fecha y hora.
            //ff->Representa los dos dígitos más significativos de la fracción de segundos en fecha y hora
            //fff->Representa los tres dígitos más significativos de la fracción de segundos; es decir,
            //representa los milisegundos en un valor de fecha y hora.
            //ffff->Representa los cuatro dígitos más significativos de la fracción de segundos; es decir,
            //representa las diezmilésimas de segundo en un valor de fecha y hora.Si bien es posible mostrar
            //las diezmilésimas de un segundo componente de un valor de tiempo, es posible que ese valor no sea significativo.
            //fffff->Representa los cinco dígitos más significativos de la fracción de segundos;
            //es decir, representa las centésimas de segundo en un valor de fecha y hora.
            //ffffff->Representa los seis dígitos más significativos de la fracción de segundos;
            //es decir, representa la millonésima de segundo en un valor de fecha y hora.
            //fffffff->Representa los siete dígitos más significativos de la fracción del segundo;
            //es decir, representa las diez millonésimas de segundo en un valor de fecha y hora.


            Console.WriteLine(fecha.ToString("yyyy/MM/dd"));
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(fecha.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(fecha.ToString("MM/dd/yyyy HH:mm"));
            Console.WriteLine(fecha.ToString("MM/dd/yyyy hh:mm tt"));
            Console.WriteLine(fecha.ToString("MM/dd/yyyy H:mm"));
            Console.WriteLine(fecha.ToString("MM/dd/yyyy h:mm tt"));
            Console.WriteLine(fecha.ToString("MM/dd/yyyy HH:mm:ss"));
            Console.WriteLine(fecha.ToString("MMMM dd"));
            Console.WriteLine(fecha.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));
            Console.WriteLine(fecha.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));
            Console.WriteLine(fecha.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss"));
            Console.WriteLine(fecha.ToString("HH:mm"));
            Console.WriteLine(fecha.ToString("hh:mm tt"));
            Console.WriteLine(fecha.ToString("H:mm"));
            Console.WriteLine(fecha.ToString("h:mm tt"));
            Console.WriteLine(fecha.ToString("HH:mm:ss"));
            Console.WriteLine(fecha.ToString("yyyy MMMM"));

            Console.ReadKey();
        }
        public static void FormatearPorTipo()
        {
            DateTime dob = new DateTime(2002, 10, 22);
            Console.WriteLine("d: " + dob.ToString("d"));
            Console.WriteLine("D: " + dob.ToString("D"));
            Console.WriteLine("f: " + dob.ToString("f"));
            Console.WriteLine("F: " + dob.ToString("F"));
            Console.WriteLine("g: " + dob.ToString("g"));
            Console.WriteLine("G: " + dob.ToString("G"));
            Console.WriteLine("m: " + dob.ToString("m"));
            Console.WriteLine("M: " + dob.ToString("M"));
            Console.WriteLine("o: " + dob.ToString("o"));
            Console.WriteLine("O: " + dob.ToString("O"));
            Console.WriteLine("r: " + dob.ToString("r"));
            Console.WriteLine("R: " + dob.ToString("R"));
            Console.WriteLine("s: " + dob.ToString("s"));
            Console.WriteLine("t: " + dob.ToString("t"));
            Console.WriteLine("T: " + dob.ToString("T"));
            Console.WriteLine("u: " + dob.ToString("u"));
            Console.WriteLine("U: " + dob.ToString("U"));
            Console.WriteLine("y: " + dob.ToString("y"));
            Console.WriteLine("Y: " + dob.ToString("Y"));
        }

        public static void FormatosFechas()
        {
            DateTime dob = new DateTime(2002, 10, 22);
            string[] dateFormats = dob.GetDateTimeFormats();
            foreach (string format in dateFormats)
            {
                Console.WriteLine(format);
            }

            //"d" Fecha corta
            //"D" Fecha larga
            //"f" Fecha completa tiempo corto.	 	 
            //"F" Fecha completa tiempo largo.	 	 
            //"g" Fecha General tiempo corto.	 	 
            //"G" Fecha General tiempo largo.	 	 
            //"M", 'm"	Mes/día.	 	 
            //"O", "o"    Tiempo redondeado.
            //"R", "r"    RFC1123
            //"s" tiempo fecha clasificado.
            //"t" tiempo corto.	 	 
            //"T" tiempo largo time.	 	 
            //"u" fecha tiempo universal	 	 
            //"U" Tiempo fecha universal largo.	 	 
            //"Y", "y"    Año Mes.	 

            dob = new DateTime(2002, 10, 22);
            // DateTime Formats: d, D, f, F, g, G, m, o, r, s, t, T, u, U,  
            Console.WriteLine("----------------");
            Console.WriteLine("d Formats");
            Console.WriteLine("----------------");
            dateFormats = dob.GetDateTimeFormats('d');
            foreach (string format in dateFormats)
                Console.WriteLine(format);
            Console.WriteLine("----------------");
            Console.WriteLine("D Formats");
            Console.WriteLine("----------------");
            dateFormats = dob.GetDateTimeFormats('D');
            foreach (string format in dateFormats)
                Console.WriteLine(format);

            Console.WriteLine("----------------");
            Console.WriteLine("f Formats");
            Console.WriteLine("----------------");
            dateFormats = dob.GetDateTimeFormats('f');
            foreach (string format in dateFormats)
                Console.WriteLine(format);

            Console.WriteLine("----------------");
            Console.WriteLine("F Formats");
            Console.WriteLine("----------------");
            dateFormats = dob.GetDateTimeFormats('F');
            foreach (string format in dateFormats)
                Console.WriteLine(format);
        }

        public static void MetodosConversion()
        {


            DateTime dob = new DateTime(2002, 10, 22);
            Console.WriteLine("ToString: " + dob.ToString());
            Console.WriteLine("ToBinary: " + dob.ToBinary());
            Console.WriteLine("ToFileTime: " + dob.ToFileTime());
            Console.WriteLine("ToLocalTime: " + dob.ToLocalTime());
            Console.WriteLine("ToLongDateString: " + dob.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + dob.ToLongTimeString());
            Console.WriteLine("ToOADate: " + dob.ToOADate());
            Console.WriteLine("ToShortDateString: " + dob.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + dob.ToShortTimeString());
            Console.WriteLine("ToUniversalTime: " + dob.ToUniversalTime());
        }

           
    }
}
