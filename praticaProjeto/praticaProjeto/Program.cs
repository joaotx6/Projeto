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
        List<Ticket> myTickets = new List<Ticket>();


        //Gerar data atual com hora e dia da semana em inteiros (sábado é o dia 6).
        DateTime CurrentDate = DateTime.Now;
        int currentHour = CurrentDate.Hour;
        int currentDay = (int)CurrentDate.DayOfWeek;

        //vai retornar V ou F se tiver dentro do horario do parque.
        bool parkStatus = HelpInterface.parkStatus(currentHour, currentDay);


        //Criação de cada zona com o valor da tarifa por hora, duração máxima em minutos,
        //capacidade do parque, e lugares disponiveis gerados de forma random.
        Zones zona1 = new Zones(1, 1.15, 45, 50, rnd.Next(10, 50));
        Zones zona2 = new Zones(2, 1, 120, 60, rnd.Next(10, 60));
        Zones zona3 = new Zones(3, 0.62, 0, 75, rnd.Next(10, 75));

        //Verificar lugares ocup
        int zone1occup = zona1.Capacity - zona1.ParkingSlots;
        int zone2occup = zona2.Capacity - zona2.ParkingSlots;
        int zone3occup = zona3.Capacity - zona3.ParkingSlots;

        


        //guardar a opcao do utilizador

        while (mainMenuActive)
        {

            // Verificar lugares disp
            int zone1availab = zona1.Capacity - zone1occup;
            int zone2availab = zona2.Capacity - zone2occup;
            int zone3availab = zona3.Capacity - zone3occup;

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
                //menu admin
                case 1:
                    HelpInterface.menuAdmin();
                    userChoiceSubMenus = HelpInterface.errorControl();

                    switch (userChoiceSubMenus)
                    {
                        case 1://ver zonas
                            HelpInterface.writeZones(zona1, zone1availab, zona2, zone2availab, zona3, zone3availab);
                            Console.ReadLine();
                            break;
                        case 2://ver hist
                            HelpInterface.showsHistoryAdmin();
                            Console.ReadLine();

                            break;
                        case 3://sair
                            Console.WriteLine("Encerrando, obrigado.");
                            Console.ReadLine();
                            Environment.Exit(0);
                            continue;
                        default:
                            Console.WriteLine("Escolha Errada. Tente novamente.");
                            Console.ReadLine();
                            break;
                    }
                    break;

                case 2://menu user
                    if (parkStatus == true)
                    {
                        HelpInterface.menuCliente();
                        userChoiceSubMenus = HelpInterface.errorControl();
                        switch (userChoiceSubMenus)
                        {
                            case 1://estacionar
                                Console.WriteLine("Qual a zona para estacionar?");
                                int zoneOfParking = HelpInterface.errorControl();
                                switch (zoneOfParking)
                                {

                                    case 1:
                                        if (zone1occup >= zona1.ParkingSlots)
                                        {
                                            Console.WriteLine("A zona 1 esta cheia.");
                                            Console.ReadLine();

                                        }
                                        else
                                        {
                                            Ticket newTicket = ParkingFunctionality.effectiveParking(zona1);
                                            if (newTicket == null)
                                            {
                                                Console.WriteLine("Operacao nao foi concluida, porque o ticket esta vazio.");
                                                Console.ReadLine();

                                            }

                                            else
                                            {
                                                myTickets.Add(ParkingFunctionality.effectiveParking(zona1));
                                                HelpInterface.printTicket(myTickets[myTickets.Count - 1]);
                                                zone1occup++; //para add 1 lugar ocupado à zona 1
                                            }
                                            Console.ReadLine();
                                        }
                                        break;
                                    case 2:
                                        if (zone2occup >= zona2.ParkingSlots)
                                        {
                                            Console.WriteLine("A zona 2 esta cheia.");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Ticket newTicket = ParkingFunctionality.effectiveParking(zona2);
                                            if (newTicket == null)
                                            {
                                                Console.WriteLine("Operacao nao foi concluida, porque o ticket esta vazio.");
                                                Console.ReadLine();

                                            }
                                            else
                                            {
                                                myTickets.Add(ParkingFunctionality.effectiveParking(zona2));
                                                HelpInterface.printTicket(myTickets[myTickets.Count - 1]);
                                                zone2occup++; //para add 1 lugar ocupado à zona 2
                                            }
                                            Console.ReadLine();
                                        }
                                        break;

                                    case 3:
                                        if (zone3occup >= zona3.ParkingSlots)
                                        {
                                            Console.WriteLine("A zona 3 esta cheia.");
                                            Console.ReadLine();

                                        }
                                        else
                                        {
                                            Ticket newTicket = ParkingFunctionality.effectiveParking(zona3);
                                            if (newTicket == null)
                                            {
                                                Console.WriteLine("Operacao nao foi concluida, porque o ticket esta vazio.");
                                                Console.ReadLine();
                                            }
                                            else
                                            {
                                                myTickets.Add(ParkingFunctionality.effectiveParking(zona3));
                                                HelpInterface.printTicket(myTickets[myTickets.Count - 1]);
                                                zone3occup++; //para add 1 lugar ocupado à zona 3
                                            }
                                            Console.ReadLine();

                                        }
                                        break;
                                }
                                break;


                            case 2://ver hist
                                HelpInterface.showsHistory(myTickets);
                                Console.ReadLine();
                                break;
                            case 3://sair
                                Console.WriteLine("Encerrando, obrigado.");
                                Console.ReadLine();
                                Environment.Exit(0);
                                continue;
                            default:
                                Console.WriteLine("Escolha Errada. Tente novamente.");
                                Console.ReadLine();
                                break;
                        }
                        break;
                    }
                    else {
                        Console.WriteLine("O parque esta fechado");
                        Console.ReadLine();
                    }
                    break;
                case 3://sair
                    Console.WriteLine("Encerrando, obrigado.");
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


