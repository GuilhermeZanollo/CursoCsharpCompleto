using Projeto35.Entities;

namespace Projeto35.Entities
{
    sealed internal class SavingsAccount : Account
    {
        public double interestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            interestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * interestRate;
        }

        public sealed override void Withdraw(double amount) // ISSO FAZ EU CONSEGUIR SOBREESCREVER A OPERAÇÃO VIRTUAL DE ACCOUNT PARA ALTERAR DA FORMA
        {                                            // QUE EU QUERO, SEM A TAXA DE 5 REAIS DA ACCOUNT
            Balance -= amount;
        }
        /*
         Um segundo exemplo de uso do override e virtual seria por exemplo:  Quero utilizar o mesmo método da classe Account, porem, 
        quero subtrair mais 2 reais:

        public override void Withdraw(double amount) 
        {               
            base.Withdraw(amount) // pegando a mesma regra de redução de 5 reais de account utilizando o base
            Balance -= 2; // saldo diminuindo mais 2 reais
        }
        */
    }
}
