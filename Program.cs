using System;

namespace exercicio123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type new client name:");
            string nome = Console.ReadLine();

            Console.WriteLine("Type email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Create a new password: ");
            string senha = Console.ReadLine();

            Console.WriteLine("Type phone number: ");
            string telefone = Console.ReadLine();

            Console.WriteLine("Type CPF: ");
            string cpf = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome, email, senha, telefone, cpf);

            Console.WriteLine("To check your password, type it again: ");
            senha = Console.ReadLine();

            cliente1.VerificarSenha(senha);

            
            if (cliente1.VerificarSenha(senha) == true)
            {
            
                Console.WriteLine("Type a new password: ");
                string newsenha = Console.ReadLine();

                cliente1.AlterarSenha(newsenha);

                Console.WriteLine("To check your password, type it again: ");
                string newsenha2 = Console.ReadLine();
            
                cliente1.VerificarSenha(newsenha2);

                if (cliente1.VerificarSenha(newsenha2) == true)
                {
                    Console.WriteLine("Type account number: ");
                    int numero = int.Parse(Console.ReadLine());

                    Conta conta1 = new Conta(numero, cliente1.ExibirCpf());

                    Console.WriteLine("Enter the amount you want to add in your account: ");
                    double valor = double.Parse(Console.ReadLine());

                    conta1.AdicionarDinheiro(valor);

                    Console.WriteLine("Enter the value you want to withdraw: ");
                    double retirarValor = double.Parse(Console.ReadLine());

                    if (conta1.RemoverDinheiro(retirarValor) == false)
                    {
                        Console.WriteLine("You can't withdraw more than you have");
                    } else
                    {
                        conta1.RemoverDinheiro(retirarValor);
                    }
                    
                } else {
                    Console.WriteLine("Wrong password");
                }

            } else {
                Console.WriteLine("Wrong password");
            }
            
        }
    }
}
