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
        public static void effectiveParking(Zones zona)
        {

            double hoursParked = 0;
            double zonePrice = zona.HourRate;

            //variavel para controlar o erro do pagamento com o while
            bool tryToPay = true;
            bool actualPay = true;

            while (tryToPay)
            {

                Console.WriteLine("Quanto tempo deseja estacionar (minutos)?");
                hoursParked = HelpInterface.errorControlDouble();
                if (hoursParked == 0)
                {
                    Console.WriteLine("Insira um valor correto. Atencao que so pode inserir numeros.");
                    Console.ReadLine();
                }
                else
                {
                    double totalCost = zonePrice * (hoursParked / 60);
                    Console.WriteLine("O custo total são " + Math.Round(totalCost, 2) + " euros.");
                    while (actualPay)
                    {
                        Console.WriteLine("Por favor insira pagamento: ");
                        double payment = HelpInterface.errorControlDouble();
                        if (payment >= totalCost)
                        {
                            Console.WriteLine("Pagamento aceite. Obrigado.");
                            Console.ReadLine();
                            tryToPay = false;
                            actualPay = false;
                        }
                        else
                        {
                            Console.WriteLine("Pagamento Invalido. Tente novamente.");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }

    }

}

