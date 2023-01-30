namespace praticaProjeto;
class Program
{
    static void Main(string[] args)
    {

        bool login = true;
        Random rnd = new Random();
        double zonePrice = 0;
        double hoursParked = 0;
        int nivel = 1;
        bool mainMenuActive = true;


        //Gerar data atual com hora e dia da semana em inteiros (sábado é o dia 6).
        DateTime CurrentDate = DateTime.Now;
        int currentHour = CurrentDate.Hour;
        int currentDay = (int)CurrentDate.DayOfWeek;

        //Dá indicação do estado do parque (hora e dia da semana) e permite inicializá-lo.
        bool parkStatus = HelpInterface.parkStatus(currentHour, currentDay);
        parkStatus = true;

        //Criação de cada zona com o valor da tarifa por hora, duração máxima em minutos,
        //capacidade do parque, e lugares disponiveis gerados de forma random.
        Zones zona1 = new Zones(1, 1.15, 45, 25, rnd.Next(1, 25));
        Zones zona2 = new Zones(2, 1, 120, 30, rnd.Next(1, 30));
        Zones zona3 = new Zones(3, 0.62, 0, 35, rnd.Next(1, 35));


        //guardar a opcao do utilizador

        while (mainMenuActive)
        {
            Console.Clear();
            Console.WriteLine(CurrentDate + "\n");
            Console.WriteLine("Bem vindo ao parquimetro!");
            Console.WriteLine("Prima qualquer tecla para verificar os menus disponiveis.");
            ConsoleKeyInfo key = Console.ReadKey();
            HelpInterface.mainMenu();
            Console.WriteLine("\n");
             
            int userChoiceMenus = HelpInterface.errorControl();
            int userChoiceSubMenus;

            switch (userChoiceMenus)
            {

                case 1:
                    HelpInterface.menuAdmin();
                    userChoiceSubMenus = HelpInterface.errorControl();

                    switch (userChoiceSubMenus)
                    {
                        case 1:
                            HelpInterface.writeZones(zona1, zona2, zona3);
                            Console.ReadLine();
                            break;
                        case 2:
                            HelpInterface.showsHistory();
                            Console.ReadLine();

                            break;
                        case 3:
                            Console.WriteLine("Adeus.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        default:
                            Console.WriteLine("Escolha Errada. Tente novamente.");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case 2:
                    HelpInterface.menuCliente();
                    userChoiceSubMenus = HelpInterface.errorControl();
                    switch (userChoiceSubMenus)
                    {
                        case 1:
                            Console.WriteLine("Qual a zona para estacionar?");
                            int zoneOfParking = HelpInterface.errorControl();
                            switch (zoneOfParking)
                            {
                                case 1: ParkingFunctionality.effectiveParking(zona1);
                                    break;
                                case 2:
                                    ParkingFunctionality.effectiveParking(zona2);
                                    break;
                                case 3:
                                    ParkingFunctionality.effectiveParking(zona3);
                                    break;

                            }
                            break;
                        case 2:
                            HelpInterface.showsHistory();
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Adeus.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        default:
                            Console.WriteLine("Escolha Errada. Tente novamente.");
                            Console.ReadLine();
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Obrigado pela visita, adeus.");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha Errada. Tente novamente.");
                    Console.ReadLine();
                    break;
            }
        }
        
    }

}


