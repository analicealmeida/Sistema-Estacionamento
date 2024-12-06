using System;
using System.Collections.Generic;

namespace Estacionamento
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos;

        public Estacionamento()
        {
            veiculos = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
            Console.WriteLine($"Veículo {veiculo.Placa} adicionado ao estacionamento.");
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.Find(v => v.Placa == placa);
            if (veiculo != null)
            {
                decimal valorCobrado = veiculo.CalcularValorCobrado();
                veiculos.Remove(veiculo);
                Console.WriteLine($"Veículo {veiculo.Placa} removido. Valor cobrado: R$ {valorCobrado}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo no estacionamento.");
                return;
            }

            Console.WriteLine("Veículos no estacionamento:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}, Modelo: {veiculo.Modelo}, Hora de Entrada: {veiculo.HoraEntrada}");
            }
        }
    }
}