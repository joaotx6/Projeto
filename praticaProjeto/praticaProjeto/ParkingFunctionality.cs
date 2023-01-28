using System;
namespace praticaProjeto
{
    public class ParkingFunctionality
    {

        public double remainingTime;
        public double ratePerMinute;

        public ParkingFunctionality(double remainingTime, double ratePerMinute)
        {
            this.remainingTime = remainingTime;
            this.ratePerMinute = ratePerMinute;
        }

        public double RemainingTime { get => remainingTime; set => remainingTime = value; }
        public double RatePerMinute { get => ratePerMinute; set => ratePerMinute = value; }


        //Aceita 1 único argumento, que é o valor da moeda, e aumenta o tempo restante 
        public void insertCoin(double coinValue)
        {
            remainingTime += coinValue / ratePerMinute;
        }


        //Verifica o tempo restante
        public double checkRemainingTime()
        {
            return remainingTime;
        }

        //Vai reduzindo o tempo restante do parque para simular o tempo a passar
        public void decrementRemainingTime()
        {

            if (remainingTime > 0)
            {
                remainingTime--;
            }
        }

        //ta a dar sempre 0 euros o custo do estacionamento
        public static void effectiveParking() {

            double hoursParked = 0;
            double zonePrice = 0;

            Console.WriteLine("Quanto tempo deseja estacionar?");
            hoursParked = double.Parse(Console.ReadLine());
            double totalCost = zonePrice * hoursParked;
            Console.WriteLine("O custo total são " + Math.Round(totalCost, 2) + " euros.");
            Console.WriteLine("Por favor insira pagamento: ");
            double payment = double.Parse(Console.ReadLine());
            if (payment >= totalCost)
            {
                Console.WriteLine("Pagamento aceite. Obrigado.");
            }
            else
            {
                Console.WriteLine("Pagamento Invalido. Tente novamente.");
            }
        }

    }

}

