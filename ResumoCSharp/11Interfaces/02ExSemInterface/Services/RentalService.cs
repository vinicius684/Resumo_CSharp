using CSharp._11Interfaces._02ExSemInterface.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._11Interfaces._02ExSemInterface.Services
{
    internal class RentalService //servico de aluguel
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brasilTaxService = new BrazilTaxService();//não é a melhor forma de fazer

        public RentalService(double pricePerHour, double pricePerDay) { 
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
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
            double tax = _brasilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
