namespace Entra21.BancoDadosAdo.net.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public decimal Pib { get; set; }    
        public UnidadeFederativa UnidadesFederativas { get; set;}

    }
}
