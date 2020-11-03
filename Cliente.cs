namespace exercicio123
{
    public class Cliente {

        private string Nome { get; set; }

        private string Email { get; set; }

        private string Senha { get; set; }

        private string Telefone { get; set; }

        private string Cpf { get; set; }

        public Cliente(string nome, string email, string senha, string telefone, string cpf) { 
            
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Telefone = telefone;
            this.Cpf = cpf;
        }

        public string ExibirNome() {
            return this.Nome;
        }

        public string ExibirEmail() {
            return this.Email;
        }

        public string ExibirSenha() {
            return this.Senha;
        }

        public string ExibirTelefone() {
            return this.Telefone;
        }

        public string ExibirCpf() {
            return this.Cpf;
        }

        public bool VerificarSenha(string senha) {
            
            if (this.Senha == senha)
            {
                return true;
            }
            else {
                return false;
            }

        }

        public string AlterarSenha(string newSenha) {
            
            return this.Senha = newSenha;

        }

    }
}