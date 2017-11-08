namespace Dados
{
    public class ContaPessoaFisica : Conta
    {

        public Pessoa pessoa { get; set; }
        
        /// <summary>
        /// Efetua saque na conta pessoa física mais 10 centavos
        /// </summary>
        /// <param name="Valor">parametro do tipo double com o valor do saque</param>
        /// <returns>Retorna o saldo</returns>
        public override double Sacar(double Valor){
            base.Sacar(Valor + 0.10);

            return this.Saldo;
        }

        /// <summary>
        /// Efetua deposito na conta pessoa fisica somando mais 0.01 ao saldo
        /// </summary>
        /// <param name="Valor">parametro do tipo double com o valor do saque</param>
        /// <returns>Retorna o saldo</returns>
        public override double Depositar(double Valor){
            System.Console.WriteLine("Efetuou um deposito no valor de R$" + Valor);
            this.Saldo += Valor + 0.01;

            return this.Saldo;
        }

        
    }
}