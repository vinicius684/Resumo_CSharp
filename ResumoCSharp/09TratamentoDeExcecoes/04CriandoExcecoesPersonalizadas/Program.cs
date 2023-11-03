using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._09TratamentoDeExcecoes._04CriandoExcecoesPersonalizadas.Entities;
using CSharp._09TratamentoDeExcecoes._04CriandoExcecoesPersonalizadas.Entities.Exception;

namespace CSharp._09TratamentoDeExcecoes._04CriandoExcecoesPersonalizadas
{
    internal class Program
    {
        public static void Main()
        {
            /*
         Solução 1 (muito ruim): logica de validação do programa principal
            -logica d valicação não delegada à reserva
         */
            /*
             Solução 2 (ruim): método retornando Update retornando string de erro ou apenas fazer a operacao
                -A semantica da operação é prejudicada
                    -Retornar string não tem nada a ver com atualização de reserva
                    -E se a operação tivesse que retornar um string
                -Ainda não é possível tratar exceções em contrutores
                -A lógica fica estruturada em condicionais aninhadas
             */
            /*
             Solução 3 (boa): utilizando tratamento de exceções personalizado
                -Logica delegada
                -Contrutores podem ter exceções
                -Cláusula throw: lança a exceção/"corta o método"
                ...
                ...
                ...
             */

            try
            {
                Console.WriteLine("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy)");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy)");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                //Solução ruim

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to updatethe reservation: ");
                Console.WriteLine("Check-in date (dd/MM/yyyy)");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy)");
                checkout = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Reservation: " + reservation);

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch (Exception e) {//Exception mais generica/superclasse, todas "cabem" nela
                Console.WriteLine("Unexpected error: " + e.Message);
            }



        }
    }
}

