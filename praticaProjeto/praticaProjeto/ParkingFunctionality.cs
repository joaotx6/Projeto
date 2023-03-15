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
        

        public static Ticket effectiveParking(Zones zona)
        {

            DateTime CurrentDate = DateTime.Now; //para controlar tempo limite estacionament dos parques
            int timeLimit = zona.Duration; //guardar tempo limite da cada zona
            int maxTime = 0;
            int currentDay = (int)CurrentDate.DayOfWeek;

            if (currentDay > 0 && currentDay < 6)
            {
                //hora limite - a hora que estamos 
                maxTime = (20 - CurrentDate.Hour) * 60 - CurrentDate.Minute;
                //guarda os minutos k faltam para o parque fechar durante semana
               
            }
            else if (currentDay == 6)
            {
                maxTime = (14 - CurrentDate.Hour) * 60 - CurrentDate.Minute;
                //guarda os minutos k faltam para o parque fechar ao sabado
                
            }

            if (timeLimit == 0 || maxTime < timeLimit) //controla tempo de todas as zonas
            {
                timeLimit = maxTime;
                
            }


            double hoursParked = 0;
            double zonePrice = zona.HourRate;
            double saldo = 0;
            double troco = 0;

            //variavel para controlar o erro do pagamento com o while
            bool tryToPay = true;
            bool actualPay = true;

            while (tryToPay)
                
            {
                Console.WriteLine($"O tempo maximo de estacionamento sao {timeLimit} minutos.");
                Console.WriteLine("Quanto tempo deseja estacionar?");
                hoursParked = HelpInterface.errorControlDouble();
                if (hoursParked <= 0)
                {
                    Console.WriteLine("Insira um valor correto. Atencao que so pode inserir numeros.");
                    Console.ReadLine();
                    return null;
                }
                else if (hoursParked <= timeLimit)
                {
                    double totalCost = Math.Round(zonePrice * (hoursParked / 60), 2); //calcula tempo de estacionamento
                    Console.WriteLine("O custo total são " + Math.Round(totalCost, 2) + " euros.");
                    while (actualPay)
                    {
                        Console.WriteLine("Por favor insira pagamento: ");
                        double moeda = HelpInterface.errorControlDouble(); //guarda valor introduzido

                        switch (moeda)
                        {
                            case 0.05:
                                saldo += moeda;
                                break;
                            case 0.1:
                                saldo += moeda;
                                break;
                            case 0.2:
                                saldo += moeda;
                                break;
                            case 0.5:
                                saldo += moeda;
                                break;
                            case 1:
                                saldo += moeda;
                                break;
                            case 2:
                                saldo += moeda;
                                break;
                            default:
                                Console.WriteLine("Por favor insira uma moeda valida.");
                                return null;
                        }
                        if (saldo > totalCost)
                        {
                            actualPay = false;
                            troco = Math.Round(saldo - totalCost, 2);
                            Console.WriteLine($"O seu troco e: {troco} eur.");
                            //logica para calcular hora de saida
                            DateTime leavingHour = CurrentDate.AddMinutes(hoursParked);
                            Console.WriteLine("Insira a sua matricula:");
                            string licensePlate = Console.ReadLine();

                            //criaçao (instancia) de objeto ticket
                            Ticket myTicket = new Ticket(zona.Id, CurrentDate, leavingHour, licensePlate, totalCost);
                            actualPay = false;
                            tryToPay = false;

                            return myTicket;
                        }
                        else if (saldo == totalCost)
                        {
                            actualPay = false;
                            tryToPay = false;
                            return null;

                        }

                        return null;
                    }
                    return null;
                }
                
                else
                {
                    Console.WriteLine("Excedeu o tempo limite.");
                    
                }
                

            }
            return null;
        }
    }
}

