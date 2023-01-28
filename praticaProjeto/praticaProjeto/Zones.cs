using System;
namespace praticaProjeto
{
    public class Zones
    {
        private double hourRate;
        private int duration;
        private int capacity;
        private int parkingSlots;

        public Zones(double hourRate, int duration, int capacity, int parkingSlots)
        {
            this.hourRate = hourRate;
            this.duration = duration;
            this.capacity = capacity;
            this.parkingSlots = parkingSlots;
        }

        public double HourRate { get => hourRate; set => hourRate = value; }
        public int Duration { get => duration; set => duration = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int ParkingSlots { get => parkingSlots; set => parkingSlots = value; }


        public void getZone1Info()
        {
            Console.WriteLine("A tarifa da zona 1 é: " + hourRate + "eur. por hora");
            Console.WriteLine("Duracao de estacionamento:" + duration + "min.");
            Console.WriteLine("Capacidade:" + capacity);
            Console.WriteLine("Lugares disponiveis:" + parkingSlots + "\n");
        }

        public void getZone2Info()
        {
            Console.WriteLine("A tarifa da zona 2 é:" + hourRate + "eur. por hora");
            Console.WriteLine("Duracao de estacionamento:" + duration + "min.");
            Console.WriteLine("Capacidade:" + capacity);
            Console.WriteLine("Lugares disponiveis:" + parkingSlots + "\n");
        }

        public void getZone3Info()
        {
            Console.WriteLine("A tarifa da zona 3 é:" + hourRate + "eur. por hora");
            Console.WriteLine("Duracao de estacionamento:" + duration + "min.");
            Console.WriteLine("Capacidade:" + capacity);
            Console.WriteLine("Lugares disponiveis:" + parkingSlots + "\n");
        }

        public void parkCar() {

            bool login = true;
            double total = 0;
            double coins = 0;
            int parkingSlot = 0;

            while (login == true)
            {
                Console.WriteLine("Introduza as moedas. Prima 0 para terminar.");
                coins = double.Parse(Console.ReadLine());
                if (coins == 0)
                {
                    Console.WriteLine("Introduziu um total de" + total + "euros.");
                    Console.WriteLine("Qual o lugar que quer estacionar?");

                    for (int i = 0; i < capacity; i++)
                    {
                        if (parkingSlot == 0)
                        {
                            Console.WriteLine("O lugar" + (i + 1) + "esta vazio.");
                        }
                        else
                        {
                            Console.WriteLine("O lugar" + (i + 1) + "esta ocupado.");
                        }
                    }
                    login = false;
                }
                else
                {
                    total = total + coins;
                    Console.WriteLine("Qual o lugar que quer estacionar?");
                }
            }

        }

    }
}

