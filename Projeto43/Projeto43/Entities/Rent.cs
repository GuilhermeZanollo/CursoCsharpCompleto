using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto43.Entities
{
    internal class Rent
    {
        public DateTime PickUp { get; set; }
        public DateTime ReturnTime { get; set; }
        public Vehicle Vehicle { get; set; } // aponta para um carro existente
        public Invoice Invoice { get; set; }

        public Rent(DateTime pickUp, DateTime returnTime, Vehicle vehicle)
        {
            PickUp = pickUp;
            ReturnTime = returnTime;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
