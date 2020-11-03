namespace exercicio123
{
    public class Conta {

        private int Numero { get; set; }

        private double Saldo { get; set; }

        private string Cpf { get; set; }

        public Conta(int numero, string cpf) {
            
            this.Numero = numero;
            this.Saldo = 0;
            this.Cpf = cpf;
        }

        public double AdicionarDinheiro(double quantidade) {
            return this.Saldo += quantidade;
        }

        public bool RemoverDinheiro(double quantidade) {
            if (this.Saldo < quantidade)
            {
                return false;
            } else
            {
                this.Saldo -= quantidade;
                return true;
            }
        }
    }
}