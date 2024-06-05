using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.App
{
    public class ListaDePrecipitaciones // Calcular el promedio anual y las variaciones.
    {
        public int Año { get; set; }

        public List<Precipitacion> Precipitaciones { get; set; }

        public ListaDePrecipitaciones(int año)
        {
            Año = año;
            Precipitaciones = new List<Precipitacion>();
        }

        public void AgregarPrecipitacion(Precipitacion precipitacion)
        {
            Precipitaciones.Add(precipitacion);
        }

        public double CalcularPromedioAnual()
        {
            double total = 0;
            foreach (var p in Precipitaciones)
            {
                total += p.Valor;
            }
            return total / Precipitaciones.Count;
        }

        public List<(string NombreMes, double Valor, double Variacion)> CalcularVariaciones(double promedioAnual)
        {
            var variaciones = new List<(string NombreMes, double Valor, double Variacion)>();
            foreach (var p in Precipitaciones)
            {
                double variacion = Math.Abs(p.Valor - promedioAnual);
                variaciones.Add((p.NombreMes, p.Valor, variacion));
            }
            return variaciones;
        }
    }
}
