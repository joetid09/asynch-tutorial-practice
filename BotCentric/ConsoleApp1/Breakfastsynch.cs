using System;
using System.Threading.Tasks;
using Toasty;


namespace AsyncBreakfast
{

    internal class Breakfastsynch
    {
        public Breakfastsynch()
        {
            MakingBreakfast();



            static Juice PourOJ()
            {
                Console.WriteLine("Pouring orange juice");
                return new Juice();
            }

            static void ApplyJam(Types toast) =>
                Console.WriteLine("Putting jam on the toast");

            static void ApplyButter(Types toast) =>
               Console.WriteLine("Putting butter on the toast");

            static Types ToastBread(int slices)
            {

                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("Putting a slice of bread in the toaster");
                }
                Console.WriteLine("Start toasting...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Remove toast from toaster");

                return new Types();
            }

            static Bacon FryBacon(int slices)
            {
                Console.WriteLine($@"putting { slices} slice of bacon in the 
                    pan");
                Console.WriteLine("cooking first side of bacon...");
                for (int slice = 0; slice < slices; slice++)
                {
                    Console.WriteLine("flipping a slice of bacon");
                }
                Console.WriteLine("cooking the second side of bacon...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Put bacon on plate");

                return new Bacon();
            }

            static Egg FryEggs(int howMany)
            {
                Console.Write("Warming the egg pan...");
                Task.Delay(3000).Wait();
                Console.Write($"cracking {howMany} eggs");
                Console.WriteLine("cooking the eggs...");
                Task.Delay(3000).Wait();
                Console.WriteLine("Putting eggs on plate");

                return new Egg();
            }

            static Coffee PourCoffee()
            {
                Console.WriteLine("Pouring coffee");
                return new Coffee();
            }

            static void MakingBreakfast()
            {
                Coffee cup = PourCoffee();
                Console.WriteLine("coffee is ready");

                Egg eggs = FryEggs(2);
                Console.WriteLine("eggs are ready");

                Bacon bacon = FryBacon(3);
                Console.WriteLine("bacon is ready");

                Types toast = ToastBread(2);
            }
        }

    }
}