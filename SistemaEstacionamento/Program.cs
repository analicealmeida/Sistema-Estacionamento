using System;

namespace Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            
            estacionamento.AdicionarVeiculo(new Veiculo("ABC-4444", "Kwid", DateTime.Now.AddHours(-2)));
            estacionamento.AdicionarVeiculo(new Veiculo("XYZ-8888", "Fiesta", DateTime.Now.AddHours(-1)));

            
            estacionamento.ListarVeiculos();

           
            estacionamento.RemoverVeiculo("ABC-4444");

            
            estacionamento.ListarVeiculos();
        }
    }
}