using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo21_Sealed_Exept
{
    public class Reservation
    {
        public int roomNumber { get; set; }

        public DateTime ChekIn {get; set;}

        public DateTime ChekOut {get; set;}

        public Reservation (int roomNumber, DateTime checkin, DateTime chekout)
        {
            this.roomNumber = roomNumber;
            this.ChekIn = checkin;
            this.ChekOut = chekout;

            if(checkin < DateTime.Now || chekout < DateTime.Now)
            {
                throw new DomainException("Datas inválidas! As datas não podem ser anteriores à data atual.");
            }

            if (chekout <= checkin)
            {
                throw new DomainException("A data de check-out deve ser posterior à data de check-in!");
            }

            this.ChekIn = checkin;
            this.ChekOut = chekout;
        }
        public void UpdateDates(DateTime checkin, DateTime chekout)
        {
            if(checkin < DateTime.Now || chekout < DateTime.Now)
            {
                throw new DomainException("Datas inválidas! As datas não podem ser anteriores à data atual.");
            }

            if (chekout <= checkin)
            {
                throw new DomainException("A data de check-out deve ser posterior à data de check-in!");
            }

            this.ChekIn = checkin;
            this.ChekOut = chekout;
        }
        public int Duration()
        {
            TimeSpan timeSpan = ChekOut.Subtract(ChekIn);
            return (int)timeSpan.TotalDays;
        }

        public override string ToString()
        {
            return $"Room {roomNumber}, check-in: {ChekIn.ToString("dd/MM/yyyy")}, check-out: {ChekOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }

    }
}