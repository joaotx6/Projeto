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

    }

}

