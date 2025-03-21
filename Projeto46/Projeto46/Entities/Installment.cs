using System.Globalization;

namespace Projeto46.Entities
{
    internal class Installment // Classe com as propriedade da parcela e ToString que vai ser utilizado para realizar a saída da lista
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate; // Data de vencimento
            Amount = amount; // Quantia da parcela
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
