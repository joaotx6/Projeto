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


        //Gerar data atual com hora e dia da semana em inteiros (sábado é o dia 6).
        DateTime CurrentDate = DateTime.Now;
        int currentHour = CurrentDate.Hour;
        int currentDay = (int)CurrentDate.DayOfWeek;

        //Dá indicação do estado do parque (hora e dia da semana) e permite inicializá-lo.
        bool parkStatus = HelpInterface.parkStatus(currentHour, currentDay);
        parkStatus = true;

        //Criação de cada zona com o valor da tarifa por hora, duração máxima em minutos,
        //capacidade do parque, e lugares disponiveis gerados de forma random.
        Zones zona1 = new Zones(1.15, 45, 25, rnd.Next(1, 25));
        Zones zona2 = new Zones(1, 120, 30, rnd.Next(1, 30));
        Zones zona3 = new Zones(0.62, 0, 35, rnd.Next(1, 35));

        Console.WriteLine("Bem vindo ao parquimetro!");
        Console.WriteLine("Prima qualquer tecla para verificar os menus disponiveis.");
        ConsoleKeyInfo key = Console.ReadKey();
        HelpInterface.mainMenu();
        Console.WriteLine("\n");


        //guardar a opcao do utilizador
        int userChoiceMenus = int.Parse(Console.ReadLine());
        int userChoiceSubMenus = int.Parse(Console.ReadLine());

        switch (userChoiceMenus)
        { 
            case 1:
                HelpInterface.menuAdmin();
                switch (userChoiceSubMenus)
                {
                    case 1:
                        //aki tem de mostrar a info das zonas todas 
                        zona1.getZone1Info();
                        break;
                    case 2:
                        HelpInterface.showsHistory();
                        break;
                    case 3:
                        Console.WriteLine("Adeus.");
                        break;
                }
                break;

            case 2:
                HelpInterface.menuCliente();
                switch (userChoiceSubMenus)
                {
                    case 1:
                        ParkingFunctionality.effectiveParking();
                        break;
                    case 2:
                        HelpInterface.showsHistory();
                        break;
                    case 3:
                        Console.WriteLine("Adeus.");
                        break;
                }
                break;
            case 3:
                Console.WriteLine("Obrigado pela visita, adeus.");
                break;
            default:
                Console.WriteLine("Escolha Errada. Tente novamente.");
                break;
        }
        
        //entrar em zonas:
        Console.WriteLine("Prima qualquer tecla para verificar as informaçoes das 3 zonas disponiveis.");
        ConsoleKeyInfo key2 = Console.ReadKey();

        zona1.getZone1Info();
        zona2.getZone2Info();
        zona3.getZone3Info();

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

        
    }

}


