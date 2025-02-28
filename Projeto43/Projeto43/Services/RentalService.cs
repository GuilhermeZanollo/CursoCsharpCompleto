using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto43.Entities;

namespace Projeto43.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; } // só pode ser modificado nessa classe
        public double PricePerDay { get; private set; } // só pode ser modificado nessa classe

        private BrazilTaxService _brazilTaxService = new BrazilTaxService(); // instanciando objeto de regra de taxa 
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
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

            double tax = _brazilTaxService.Tax(basicPayment);

            rent.Invoice = new Invoice(basicPayment, tax);
        }
    }
}



/*
* Stack é um espaço separado pelo sistema operacional (Possui um limite) -> Por isso tem uma exception para ela caso vc ultrapasse: Exception StackOverFlow
* Objetos pequenos
* Tem vida Curta
* Desalocamento da memoria feito de maneira "simples"
* Tipos Primitivos
* Value Types
* 
* Heap não possui um tamanho fixo
* Objetos com tempo de vida maior
* Garbage Collector -> faz a desalocação do objeto que não está mais em uso
* Ref Types
*/