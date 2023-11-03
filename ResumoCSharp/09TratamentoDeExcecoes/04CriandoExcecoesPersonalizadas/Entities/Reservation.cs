using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._09TratamentoDeExcecoes._04CriandoExcecoesPersonalizadas.Entities.Exception;

namespace CSharp._09TratamentoDeExcecoes._04CriandoExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout) { //gera exceção do try, cai no catch
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration() {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout) { //gera exceção no try, cai no catch
            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must beafter check-in date");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", check-in: " + Checkin.ToString("dd/MM/yyyy") + ", check-out: " +
                Checkout.ToString("dd/MM/yyyy") + ", " + Duration() + " nights";
        }
    }
}
