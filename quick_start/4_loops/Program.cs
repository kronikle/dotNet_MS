using System;

namespace _4_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            if (a + b > 10){
                Console.WriteLine("The answer is greater than 10");
            } else {
                Console.WriteLine("The answer is not greater than 10");
            }

            //il while controlla prima poi esegue
            int counter = 0;
            while (counter < 10) 
            {
                Console.WriteLine($"Hello World! The counter is {counter}.");
                counter++;
            }
            Console.WriteLine();
            //il do..while prima esegue il codice poi controlla
            int counterDo = 0;
            do 
            {
                Console.WriteLine($"Hello World! The counter is {counterDo}");
                counterDo++;
            } while (counterDo < 10);


            Console.WriteLine();
            //for loop
            for (int countFor = 0; countFor < 10; countFor++) {
                Console.WriteLine($"Hello World! the counter is {countFor}!");
            }

            //esercizio
            int sum = 0;
            for(int i = 1; i <= 20; i++) {
                if (i % 3 == 0) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
