using CSharp._11Interfaces._03ComInterface.Entites;


namespace CSharp._11Interfaces._03ComInterface.Services
{
    internal class RentalService //servico de aluguel
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService; // agora tenho os dois serviços desacoplados entre si por meio da interface

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) { 
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            _taxService = taxService;
        }

        public void ProcesInvoice(CarRental carRental) {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // Math.Ceiling - arredonda pra cima
            }
            else { 
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
