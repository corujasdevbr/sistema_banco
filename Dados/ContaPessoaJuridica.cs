using System;

namespace Dados
{
    public class ContaPessoaJuridica : Conta
    {
        public Empresa empresa { get; set; }
        /// <summary>
        /// Efetua saque na conta pessoa física mais 50 centavos
        /// </summary>
        /// <param name="Valor">parametro do tipo double com o valor do saque</param>
        /// <returns>Retorna o saldo</returns>
        public override double Sacar(double Valor    ){
            this.Saldo -= (Valor + 0.50);
            return this.Saldo;
        }

        
        public void CadastrarConta(string Numero, string Agencia, string Conta, string RazaoSocial, DateTime DataAbertura, string CNPJ){

        }
    }
}