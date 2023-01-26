namespace praticaProjeto;
class Program
{
    static void Main(string[] args)
    {

        bool login = true;
        Random rnd = new Random();

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

    }
}

