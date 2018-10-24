using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите расстояние(км): ");
            double length = 0;
            bool isTrue = false;
            while (!isTrue && length<=0)
            {
                isTrue = double.TryParse(Console.ReadLine(), out length);
                if (!isTrue) Console.WriteLine("введите расстояние в километрах: ");
            }           
            Bus bus = new Bus();
            SpeedCar speedCar = new SpeedCar();
            Truck truck = new Truck();
            Game game = new Game();
            game.ActionEventGo += speedCar.Go;
            game.ActionEventGo += bus.Go;
            game.ActionEventGo += truck.Go;
            game.ActionEventMessage += new StartMessage().SendMessage;
            game.ActionEventFinish += new FinishMesssage().SendMessage;
            game.ActionEventCarPosition = new CarPositionMessage().SendMessage;
            for (int i = 0; ; i++)
            {
                if (i == 0)
                {
                    game.StartSendMessage("Начинаем гонку");
                    Console.WriteLine("--------------------------------");
                    continue;
                }
                game.Go(i);
                game.CarPositionSendMessage(bus.Name, bus.KiloMetr);
                game.CarPositionSendMessage(truck.Name, truck.KiloMetr);
                game.CarPositionSendMessage(speedCar.Name, speedCar.KiloMetr);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++");
                if (bus.isFinish(bus.KiloMetr) || speedCar.isFinish(speedCar.KiloMetr) || truck.isFinish(truck.KiloMetr))
                {
                    bool isFinishCar = false;
                    if (truck.isFinish(length))
                    {
                        game.FinishMessage(truck.Name);
                        isFinishCar = true;
                    }

                    if (bus.isFinish(length))
                    {
                        game.FinishMessage(bus.Name);
                        isFinishCar = true;
                    }
                        
                    if (speedCar.isFinish(length))
                    {
                        game.FinishMessage(speedCar.Name);
                        isFinishCar = true;
                    }
                    if (isFinishCar)
                    {
                        Console.WriteLine("Нажмите любую  клавишу,чтобы закрыть программу ");
                        Console.ReadKey();
                        Environment.Exit(1);
                    }
                                                          
                }
            }
        }
    }
}
