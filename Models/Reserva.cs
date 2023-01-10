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
            // Implementado!!!

            if (Suite.Capacidade> hospedes.Count ) {
                Hospedes = hospedes;
            }
            else {
                
                try {
                    throw new Exception();
                }
                catch(Exception ex) {
                    Console.WriteLine($"Ocorreu um erro. A capacidade da suite é menor que o número de pessoas. "+ ex.Message);
                }   
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Implementado!!!
            
          if(Hospedes != null) {
            return Hospedes.Count;
          }
            return 0;
        }

       public decimal CalcularValorDiaria()
       {
            // Implementado!!!
            
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;


            if (DiasReservados >= 10)
            {
                valor = valor-(valor*0.10M);
            }

            return valor;
        }
    }
}
