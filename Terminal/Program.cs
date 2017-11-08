using System;
using Dados;
using Util;
namespace Terminal
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "";
            
            //Menu principal 
            do{
                Console.WriteLine("Digite a opção");
                Console.WriteLine("1 - Cadastrar Conta");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Depositar");
                Console.WriteLine("9 - Sair");
                
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    {
                        CadastrarConta();
                        break;
                    }
                }
            }while(opcao != "9");
        }

        static void CadastrarConta(){
            Console.WriteLine("Digite a Razao Social");
            string razaosocial = Console.ReadLine();

            Console.WriteLine("Digite a data de abertura");
            string dataabertura = Console.ReadLine();
            
            Validacao validacao = new Validacao();
            bool cnpjvalido = false;

            do{
                Console.WriteLine("Digite seu cnpj");
                string cnpj = Console.ReadLine();
                cnpjvalido = validacao.ValidarCNPJ(cnpj);

                if(cnpjvalido != true){
                    Console.WriteLine("Cnpj inválido");
                }
            }while(cnpjvalido != true);


        }
    }
}
