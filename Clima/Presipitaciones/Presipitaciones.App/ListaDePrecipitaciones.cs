namespace Presipitaciones.App
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
            for (int i = 0; i < Precipitaciones.Count; i++)
            {
                total += Precipitaciones[i].Valor;
            }
            return total / Precipitaciones.Count;
        }

        public List<(string NombreMes, double Valor, double Variacion)> CalcularVariaciones(double promedioAnual)
        {
            var variaciones = new List<(string NombreMes, double Valor, double Variacion)>();
            for (int i = 0; i < Precipitaciones.Count; i++)
            {
                double variacion = Math.Abs(Precipitaciones[i].Valor - promedioAnual);
                variaciones.Add((Precipitaciones[i].NombreMes, Precipitaciones[i].Valor, variacion));
            }
            return variaciones;
        }
    }
}
