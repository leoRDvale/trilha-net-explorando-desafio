namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"Não há vagas suficientes para a quantidade selecionada.\n Há {Suite.Capacidade} vagas disponíveis.");
        }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal novoValor = valor - (valor * 0.10M);

            if (DiasReservados >= 10)
            {
                valor = novoValor;
                Console.WriteLine($"Para reservas acima de 10 dias, concedemos um desconto de 10% :");
            }

            return valor;
        }
    }
}
