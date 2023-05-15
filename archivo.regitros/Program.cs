using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARCHIVO
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa un registro:");
            String NumRegistros = Console.ReadLine();
            if (String.IsNullOrEmpty(NumRegistros))
            {
                Console.WriteLine("No se ingresó ningún registro.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Ingresa registro de control :");
                String filename = Console.ReadLine();
                if (String.IsNullOrEmpty(filename))
                {
                    Console.WriteLine("No se ingresó el registro de control.");
                    Environment.Exit(0);
                }
                else
                {
                    Int32 repeticiones = Int32.Parse(NumRegistros);
                    String Tregistro, Nidentificacion, Cidentidad, fecha, hora, reservado, septimo, octavo, noveno, decimo, once, linea = "";
                    for (Int32 i = 1; i <= repeticiones; i++)
                    {
                     Tregistro Left(2, 0,1);
                     Nidentificacion Left(RandomNumber.Generar(), 16);
                     Cidentidad = "3";
                     fecha = FechaRandom.Fecha();
                     reservado = CerosRellenar.Left(RandomNumber.Generar(), 170);
                     Console.WriteLine(date1.ToString("hh:mm:ss.F", ci));

                    linea += Tregistro + Nidentificacion + Cidentidad + fecha + hora + reservado +;
                    linea += "\n";
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(@"D:\Users\maguilarm\source\repos\archivo\archivo\" + filename + ".txt"))
                        {
                            writer.Write(linea);

                        }



                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }





        }
    }
}
}