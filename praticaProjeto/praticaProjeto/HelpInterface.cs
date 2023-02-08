using System;
namespace praticaProjeto
{
    public class HelpInterface
    {

        public static bool parkStatus(int hour, int dayOfWeek)
        {

            if (dayOfWeek < 6 && hour >= 9 && hour < 20)
            {
                return true;
            }
            else if (dayOfWeek == 6 && hour >= 9 && hour < 14)
            {
                return true;
            }
            else return false;
        }

        public static void mainMenu()
        {

            Console.Clear();
            Console.WriteLine("1. Menu admin.");
            Console.WriteLine("2. Menu User.");
            Console.WriteLine("3. Sair.");

        }

        public static void menuAdmin()
        {

            Console.Clear();
            Console.WriteLine("1. Ver zonas.");
            Console.WriteLine("2. Ver historico.");
            Console.WriteLine("3. Sair.");
        }

        public static void menuCliente()
        {

            Console.Clear();
            Console.WriteLine("1. Estacionar.");
            Console.WriteLine("2. Ver historico.");
            Console.WriteLine("3. Sair.");

        }

        public static void showsHistory(List<Ticket> tickets)
        {
            Console.Clear();
            for (int i = 0; i < tickets.Count; i++)
            {
                Console.WriteLine($"Ticket {i + 1}: Zona {tickets[i].IdZona} data de entrada {tickets[i].StartingTime}, data de saida: {tickets[i].LeavingTime}, com matricula: {tickets[i].LicensePlate} e valor pago: {tickets[i].PaidValue}");
            }
            Console.ReadLine();
        }

        public static void showsHistoryAdmin()
        {
            Console.Clear();
            Console.WriteLine("Em construcao");
            Console.ReadLine();
        }


        public static void writeZones(Zones zona1, int zona1Avai, Zones zona2, int zona2Avai, Zones zona3, int zona3Avai)
        {
            Zones.getZoneInfo(zona1, zona1Avai);
            Zones.getZoneInfo(zona2, zona2Avai);
            Zones.getZoneInfo(zona3, zona3Avai);
        }

        public static void printTicket(Ticket ticket)
        {
            Console.Clear();
            Console.WriteLine("Ticket:");
            Console.WriteLine($"A zona que estacionou foi a zona: {ticket.IdZona}");
            Console.WriteLine($"A data de entrada foi: {ticket.StartingTime}");
            Console.WriteLine($"A data de saida sera: {ticket.LeavingTime}");
            Console.WriteLine($"A matricula e: {ticket.LicensePlate}");
            Console.WriteLine($"O valor pago foi: {ticket.PaidValue} eur");
        }

        public static int errorControl()
        {
            //controlar o erro de input
            bool trueInput = int.TryParse(Console.ReadLine(), out var readedInput);
            if (trueInput)
            {
                return readedInput;
            }
            else
            {
                return 0;
            }

        }

        public static double errorControlDouble()
        {
            //controlar o erro de input
            bool trueInput = double.TryParse(Console.ReadLine(), out var readedInput);
            if (trueInput)
            {
                return readedInput;
            }
            else
            {
                return 0;
            }

        }
    }
}