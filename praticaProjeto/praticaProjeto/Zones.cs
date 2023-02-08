using System;
namespace praticaProjeto
{
    public class Zones
    {
        private int id;
        private double hourRate;
        private int duration;
        private int capacity;
        private int parkingSlots;

        public int Id { get => id; set => id = value; }
        public double HourRate { get => hourRate; set => hourRate = value; }
        public int Duration { get => duration; set => duration = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int ParkingSlots { get => parkingSlots; set => parkingSlots = value; }

        public Zones(int id, double hourRate, int duration, int capacity, int parkingSlots)
        {
            this.id = id;
            this.hourRate = hourRate;
            this.duration = duration;
            this.capacity = capacity;
            this.parkingSlots = parkingSlots;
        }

        public static void getZoneInfo(Zones zona, int zonaAvailable)

        {
            Console.WriteLine($"A tarifa da zona {zona.id} é: {zona.hourRate} eur. por hora");
            Console.WriteLine($"Duracao de estacionamento sao {zona.duration} min.");
            Console.WriteLine($"A capacidade é: {zona.capacity}");
            Console.WriteLine($"Lugares disponiveis: {zonaAvailable}\n");
        }
    }
}

