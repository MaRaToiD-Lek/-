using System;

namespace Задание_1
{
    class Program
    {        
        static void Main(string[] args)
        {            
            Heading();
            byte team = byte.Parse(Console.ReadLine());
            Team(team);
            Console.WriteLine("Нажмите на любую клавишу что-бы продолжить!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Первым начинаете вы! Нажмите на любую клавишу что-бы шотнуть!");
            //string shot = Console.ReadLine();

            while (true)
            {              
                string shot = Console.ReadLine();                
                Pong pong = new Pong(0);
                pong.Notify += DisplayMessage;   
                pong.Put(1);    
                Ping ping = new Ping(0);
                ping.Notify += DisplayMessage;   
                ping.Put(1);                
                ping.Take(1);                 
                Console.WriteLine("Нажмите на любую клавишу что-бы шотнуть!");
            }                      
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void Team(byte team)
        {
            switch (team)
            {
                case 1:
                    Console.WriteLine("Вы играете за команду Ping");
                    break;
                case 2:
                    Console.WriteLine("Вы играете за команду Pong");
                    break;
            }
        }
        public static void Heading()
        {
            Console.WriteLine("\t \tНачинаем игру!");
            Console.WriteLine("За какую команду хотите играть? Ping(1) или Pong(2)?");
        }
    }
}

