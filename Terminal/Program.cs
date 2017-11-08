using System;
using Dados;
using Util;
namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cria um objeto do tipo Validação da Biblioteca Util
            // Validacao validacao = new Validacao();

            // //Declaração de variáveis
            // bool cpfvalido = false;
            // string cpf = "";

            // do
            // {
            //     //Pede o cpf para o usuário
            //     Console.WriteLine("Informe seu cpf");
            //     //Recebe o cpf do usuário
            //     cpf = Console.ReadLine();
                
            //     //Recebe o retorno do metodo Validar Cpf
            //     cpfvalido = validacao.ValidarCPF(cpf);

            //     //Caso seja um cpf inválido informa ao usuário
            //     if(cpfvalido == false){
            //         Console.WriteLine("Cpf inválido");
            //     }


            // } while (cpfvalido == false);// Faça enquanto cpf inválido

            // Console.WriteLine("Cpf válido");
            /*
            //Cria o objeto do tipo Conta e instancia
            Conta conta = new Conta();
            
            //Deposita o valor na conta
            conta.Depositar(100.00);

            //Mostra o saldo para o usuário
            Console.WriteLine("Seu saldo é: " + conta.Saldo);

            conta.Depositar(100.00);

            //Mostra o saldo para o usuário
            Console.WriteLine("Seu saldo é: " + conta.Saldo);

            conta.Sacar(50.00);

            //Mostra o saldo para o usuário
            Console.WriteLine("Seu saldo é: " + conta.Saldo);
             */

            ContaPessoaFisica contapf = new ContaPessoaFisica() ;
            contapf.Sacar(50.00);
                        
            //Mostra o saldo para o usuário
            Console.WriteLine("Seu saldo é: " + contapf.Saldo);

            contapf.Depositar(100000000.00);
            Console.WriteLine("Seu saldo é: " + contapf.Saldo);
        }
    }
}
