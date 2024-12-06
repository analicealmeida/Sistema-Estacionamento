using System;

namespace Estacionamento
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }

        public Veiculo(string placa, string modelo, DateTime horaEntrada)
        {
            Placa = placa;
            Modelo = modelo;
            HoraEntrada = horaEntrada;
        }

        public decimal CalcularValorCobrado()
        {
            TimeSpan tempoEstacionado = DateTime.Now - HoraEntrada;
            
            decimal valor = (decimal)tempoEstacionado.TotalHours * 8;

            
            return Math.Ceiling(valor);
        }
    }
}