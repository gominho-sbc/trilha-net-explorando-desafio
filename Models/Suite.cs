namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        // Propriedades da classe (Acesso controlado aos dados)
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        // Construtores (Inicializa o objeto)
        public Suite() { }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }

      
    }
}