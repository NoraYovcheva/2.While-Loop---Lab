﻿namespace _05.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //входни данни
            int number = int.Parse(Console.ReadLine());//числото, на което трябва да намерим сумата от цифрите
            int sum = 0;//намираме сумата на цифрите на числото
            //повтаряме действията неопределн брой пъти
            //1.вземаме последната цифра на числото 
            //2.добавяме последната цифра към сумата на цифрите 
            //3. премахваме последната цифра 
            //стоп: когато нямаме повече цифри в числото number <= 0
            //продължаваме: когато имаме цифри в числото number > 0
            while (number > 0)
            {
                //1.вземаме последната цифра на числото 
                int lastNumber = number % 10;
                //2.добавяме последната цифра към сумата на цифрите 
                sum += lastNumber;
                //3. премахваме последната цифра 
                number /= 10;
            }
            //отпечатваме натрупаната сума
            Console.WriteLine(sum);
        }
    }
}
