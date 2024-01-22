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
            
            
            Console.Write(" Por favor digite o numero da placa:  ");
             string veiculoInserido = Console.ReadLine();

             veiculos.Add(veiculoInserido);

            
        }
          public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

           
            string placa = "";   
            Console.Write(" ");
            placa=Console.ReadLine();
            

          
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                
                int horas = 0;
                decimal valorTotal = 0; 

                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                 horas = int.Parse(Console.ReadLine());

                valorTotal= precoInicial+ precoPorHora * horas;
                
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
         public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
               foreach(string veiculo in veiculos)
               {
                Console.Write(veiculo);
               }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}