namespace Entra21.BancoDadosAdo.net.Models
{
    public class Cidades
    {
        public int Id { get; set; }
        public UnidadesFederativas UnidadesFederativas { get; set;}
        public string Nome { get; set; }
        public int QuantidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public decimal Pib { get; set; }    

    }
}
