using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_02_Modulo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Obtiene el mes y año actuales */
            DateTime hoy = DateTime.Now;
            int anio = hoy.Year;
            int mes = hoy.Month;

            /* Día 1 del mes actual */
            DateTime primerDia = new DateTime(anio, mes, 1);
            int diaDeLaSemana = (int)primerDia.DayOfWeek;

            /* Número de días del mes actual */
            int diasDelMes = DateTime.DaysInMonth(anio, mes);

            /* Imprime el nombre del mes y año */
            Console.WriteLine($"\n{hoy:MMMM yyyy}".ToUpper());
            Console.WriteLine("Lu Ma Mi Ju Vi Sa Do");

            /* Añade espacios al inicio */
            for (int i = 1; i < diaDeLaSemana; i++)
            {
                Console.Write("   ");
            }

            /* Imprime los días del mes */
            for (int dia = 1; dia <= diasDelMes; dia++)
            {
                Console.Write($"{dia,2} "); /* Imprime el día con 2 espacios */
                if ((diaDeLaSemana + dia - 1) % 7 == 0) /* Salto de línea al domingo */
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
