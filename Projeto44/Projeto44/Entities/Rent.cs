namespace Projeto44.Entities
{
    internal class Rent
    {
        public DateTime PickUp { get; set; }
        public DateTime ReturnTime { get; set; }
        public Vehicle Vehicle { get; set; } // aponta para um carro existente
        public Invoice Invoice { get; set; } // aponta para o invoice

        public Rent(DateTime pickUp, DateTime returnTime, Vehicle vehicle)
        {
            PickUp = pickUp;
            ReturnTime = returnTime;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
