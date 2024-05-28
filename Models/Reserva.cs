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
            try
            {
                if (hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else{
                    throw new Exception();
                }
            }            
            catch (System.Exception)
            {
               Console.WriteLine("Quantidade de hospedes informado excede quantidade permitida.\n\n");
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
            decimal valor = 0;
            decimal desconto = 0.90m;

            if (DiasReservados > 0)
            {
                valor = DiasReservados * Suite.ValorDiaria;
                if (DiasReservados >= 10)
                {
                    valor = valor * desconto; // Aplicando um desconto de 10%
                }
            }
            return valor;
        }
    }
}