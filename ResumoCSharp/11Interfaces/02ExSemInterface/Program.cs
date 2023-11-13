using System.Globalization;
using CSharp._11Interfaces._02ExSemInterface.Entites;
using CSharp._11Interfaces._02ExSemInterface.Services;

namespace CSharp._11Interfaces._02ExSemInterface
{
    internal class Program
    {
        public static void Main()
        {
            /*Solução sem utilizar interface*/
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string carModel = Console.ReadLine();
            Console.Write("Pickup(dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
            Console.Write("Return(dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));

            Console.Write("Enter price per hour: ");
            double priceH = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double priceD = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(priceH, priceD);

            rentalService.ProcesInvoice(carRental);

            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
