namespace ElTiempoWeb.Models
{

    public class Estadistica
    {
        public int Id { get; set; }
        public string Ciudad { get; set; }
        public int Mes { get; set; }
        public double TempMax { get; set; }
        public double TempMedia { get; set; }
        public double TempMin { get; set; }
        public double Precipitacion { get; set; }
        public double Viento { get; set; }
        public double Humedad { get; set; }
    }

}
