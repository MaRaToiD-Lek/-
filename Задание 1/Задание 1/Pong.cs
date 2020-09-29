using System;

namespace Задание_1
{
    class Pong
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify; // 1.Определение события
        public Pong(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke("Произошёл пинг. Понг получил пинг"); // 2.Вызов события 
        }        
    }
}
