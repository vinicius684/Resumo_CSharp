using System.Globalization;
using CSharp._11Interfaces._03ComInterface.Services;
using CSharp._11Interfaces._03ComInterface.Entites;

namespace CSharp._11Interfaces._03ComInterface
{
    internal class Program
    {
        public static void Main()
        {
            /*
               =====Solução utilizando interface=====
 
                private BrazilTaxService _brasilTaxService = new BrazilTaxService(); //Dependencia

                -dessa forma fica muito forte a dependencia entre os dois serviços, RentalService fica dependendo somente do BrasilTaxService
                -Se no futuro eu precisar trocar o serviço de imposto do Brasil por um serviço de imposto de outro país, vou ter que abrir a RentalService e trocar a implementação
                -RentalService não está fechada para alteração. O ideal é que eu tenha uma classe que fique fechada para alteração
                -Se eu alterar a dependencia dela, o ideal é que não tenha que alterar nada nela
             */
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

            RentalService rentalService = new RentalService(priceH, priceD, new BrazilTaxService());//instanciando já passando a dependencia que eu quero

            rentalService.ProcesInvoice(carRental);

            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
