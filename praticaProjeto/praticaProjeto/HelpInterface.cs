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
            else if (dayOfWeek == 7 && hour >= 9 && hour < 14)
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

        public static void menuAdmin() {

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

        public static void showsHistory()
        {
            Console.WriteLine("O historico esta em construcao.");

        }

        public static void effectiveParking()
        {
            Console.WriteLine("A estacionar em zona.");

        }

    }
}

