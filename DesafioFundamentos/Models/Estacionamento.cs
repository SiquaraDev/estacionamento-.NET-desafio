namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                veiculos.Remove(placa);
                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}.");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");

                foreach(string placa in veiculos) {
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.");
            }
        }
    }
}
