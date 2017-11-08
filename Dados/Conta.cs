namespace Dados
{
    public class Conta
    {
        public string Numero { get; set; }
        public string Agencia { get; set; }
        public double Saldo { get; protected set; }

        /// <summary>
        /// Efetua o saque na conta do cliente
        /// </summary>
        /// <param name="Valor">Recebe um parametro do tipo double com o valor do saque</param>
        /// <returns>Retorna o valor do saldo</returns>
        public virtual double Sacar(double Valor){
            this.Saldo -= Valor;
            return this.Saldo;
        }

        /// <summary>
        /// Efetua o deposito na conta do cliente
        /// </summary>
        /// <param name="Valor">Recebe um parametro do tipo double com o valor do saque</param>
        /// <returns>Retorna o valor do saldo</returns>
        public virtual double Depositar(double Valor){
            this.Saldo += Valor;
            return this.Saldo;
        }
    }
}