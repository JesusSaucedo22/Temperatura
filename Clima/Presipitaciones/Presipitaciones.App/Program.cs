using Presipitaciones.App;

namespace PrecipitacionAnual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de los meses
            string[] nombresMeses = {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo",
                "Junio", "Julio", "Agosto", "Septiembre", "Octubre",
                "Noviembre", "Diciembre"

            }; Console.WriteLine();

            // Lista de precipitaciones
            Console.WriteLine(); //Saltos de linea
            ListaDePrecipitaciones lista = new ListaDePrecipitaciones(2024);

            // Datos de presipitaciones por teclado
            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Ingrese la precipitación promedio para {nombresMeses[i]}: ");
                double valor = double.Parse(Console.ReadLine());
                Console.WriteLine(); // Salto de linea
                Precipitacion precipitacion = new Precipitacion(i + 1, nombresMeses[i], valor);
                lista.AgregarPrecipitacion(precipitacion);
            }

            // Calcular el promedio anual
            double promedioAnual = lista.CalcularPromedioAnual();

            // Calcular las variaciones
            var variaciones = lista.CalcularVariaciones(promedioAnual);

            // Resultados!
            Console.WriteLine($"Precipitación promedio anual: {promedioAnual:F2} mm.");
            Console.WriteLine("Mes         Promedio  Variación");
            for (int i = 0; i < variaciones.Count; i++)
            {
                var (nombreMes, valor, variacion) = variaciones[i];
                Console.WriteLine($"{nombreMes,-10} {valor,-9:F2} {variacion:F2}");
            }
        }
    }
}