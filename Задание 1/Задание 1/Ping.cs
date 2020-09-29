using System;

namespace Задание_1
{
    class Ping : Program
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify; 
        public Ping(int score)
        {
            Score = score;
        }
        public int Score { get; private set; }
        public void Put(int score)
        {
            Score += score;
            Notify?.Invoke("Произошёл понг. Пинг получил понг"); 
        }
        public void Take(int score)
        {
            if (Score <= score)
            {
                Score += score;
                //Notify?.Invoke($"Со счета снято: {score}"); 
            }            
        }
    }
}
