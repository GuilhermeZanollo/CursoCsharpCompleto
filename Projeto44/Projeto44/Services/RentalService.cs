using Projeto44.Entities;

namespace Projeto44.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; } // só pode ser modificado nessa classe
        public double PricePerDay { get; private set; } // só pode ser modificado nessa classe

        private ITaxService _taxService; // Injeção de dependência

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) // Inversão de controle, por meio de injeção de dependência
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(Rent rent)
        {
            TimeSpan duration = rent.ReturnTime.Subtract(rent.PickUp); // "Pegue a propriedade ReturnTime do objeto rent e chame o
                                                                       // método Subtract, passando como argumento a propriedade PickUp
                                                                       // do mesmo objeto rent, para calcular a diferença entre os dois valores."

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0) // 
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment); // Passando valor de basicPayment para tax

            rent.Invoice = new Invoice(basicPayment, tax); // // A invoice é criada e atribuída à propriedade Invoice do objeto Rent
        }
    }
}