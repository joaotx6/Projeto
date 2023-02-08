using System;
namespace praticaProjeto
{

	public class Ticket
	{
		private int idZona;
		private DateTime startingTime;
		private DateTime leavingTime;
		private string licensePlate;
		private double paidValue;

        public Ticket(int idZona, DateTime startingTime, DateTime leavingTime, string licensePlate, double paidValue)
        {

            this.idZona = idZona;
            this.startingTime = startingTime;
            this.leavingTime = leavingTime;
            this.licensePlate = licensePlate;
            this.paidValue = paidValue;
        }

       
        public int IdZona { get => idZona; set => idZona = value; }
        public DateTime StartingTime { get => startingTime; set => startingTime = value; }
        public DateTime LeavingTime { get => leavingTime; set => leavingTime = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }
        public double PaidValue { get => paidValue; set => paidValue = value; }
    }

}

