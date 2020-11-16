using System;

namespace KAA_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int coins;
            int price = 15;
            int numberOfcrystals;
            Console.Write("Введите колличество монет: ");
            coins = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Стоимость одного кристалла {price} монет. Сколько желаете купить?: ");
            numberOfcrystals = Convert.ToInt32(Console.ReadLine());
            if ((numberOfcrystals * price) <= coins)
                coins = coins - (numberOfcrystals * price);
            else
                numberOfcrystals = 0;
            Console.WriteLine($"У Вас в сумке осталось {coins} монет и появилось {numberOfcrystals} кристаллов");


        }
    }
}