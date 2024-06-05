namespace Presipitaciones.App
{
    public class Precipitacion  //Definimos el nombre del mes, numero y valor de su precipitacion.
    {
        public int NumeroMes { get; set; }
        public string NombreMes { get; set; }
        public double Valor { get; set; }

        public Precipitacion(int numeroMes, string nombreMes, double valor)
        {
            NumeroMes = numeroMes;
            NombreMes = nombreMes;
            Valor = valor;
        }
    }
}
