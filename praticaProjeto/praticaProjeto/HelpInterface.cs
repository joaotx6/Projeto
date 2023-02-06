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

        public static void showsHistory()
        {
            Console.WriteLine("O historico esta em construcao e nao vai ficar pronto.");

        }

        public static void writeZones(Zones zona1, Zones zona2, Zones zona3)
        {
            Zones.getZoneInfo(zona1);
            Zones.getZoneInfo(zona2);
            Zones.getZoneInfo(zona3);
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

        /*
        Console.WriteLine("Agora escolha a zona que pretende estacionar (1, 2 ou 3).");

        //guardar a opcao do utilizador
        //Pergunta ao utilizador de 3 zonas, qual quer estacionar e determina o valor de
        //cada zona. Depois calcula o custo total com base na tarifa horária e tempo de parque.
        //Finalmente, pede ao utilizador para inserir pagamento
        //Verifica se o pagamento é maior ou igual ao custo total, e imprime OK caso
        //seja positivo, ou tente novamente caso seja negativo.
        int userChoice = int.Parse(Console.ReadLine());
        switch (userChoice)
        {
            case 1:
                Console.WriteLine("Escolheu a zona 1.");
                zonePrice = 1.15;
                ParkingFunctionality.effectiveParking();
                break;
            case 2:
                Console.WriteLine("Escolheu a zona 2.");
                zonePrice = 1;
                ParkingFunctionality.effectiveParking();
                break;
            case 3:
                Console.WriteLine("Escolheu a zona 3.");
                zonePrice = 0.62;
                ParkingFunctionality.effectiveParking();
                break;
            default:
                Console.WriteLine("Escolha Errada. Tente novamente.");
                break;
        }
        */
    }

}


