using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _23AsyncBreakfast
{
    public class AsyncBreakfast
    {
        public async Task<Coffee> MakeCoffee()
        {
            Console.WriteLine("Starting a pot of coffee");
            await Task.Delay(8000);
            Console.WriteLine("Pouring a cup of coffee");
            await Task.Delay(2000);

            return new Coffee();
        }

        public async Task<FrenchToast> MakeFrenchToast(int count)
        {
            Console.WriteLine($"Putting {count} pieces of bread into the dip.");
            await Task.Delay(1000);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Flipping a piece of bread in the dip.");
            }
            await Task.Delay(1000);

            Console.WriteLine($"Putting {count} pieces of dipped bread into the pan.");
            await Task.Delay(4000);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Flipping a piece of French toast.");
            }

            await Task.Delay(4000);
            Console.WriteLine("Putting the French toast on the plate.");

            return new FrenchToast();
        }

        public async Task<Bacon> FryBacon(int count)
        {
            Console.WriteLine($"Putting {count} slices of bacon in the pan.");
            Console.WriteLine("Cooking first side of bacon...");
            await Task.Delay(3000);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Flipping a piece of bacon");
            }

            Console.WriteLine("Cooking the other side of the bacon.");
            await Task.Delay(3000);

            Console.WriteLine("Adding the bacon to the plate.");

            return new Bacon();
        }

        public async Task<Eggs> MakeScrambledEggs()
        {
            Console.WriteLine("Putting oil into a pan.");
            Console.WriteLine("Heating the pan.");
            await Task.Delay(3000);
            Console.WriteLine("Making the scrambled eggs.");
            await Task.Delay(8000);
            Console.WriteLine("Putting the eggs on the plate.");

            return new Eggs();
        }

        public async Task<Bagel> MakeBagel()
        {
            Console.WriteLine("Toasting a bagel");
            await Task.Delay(7000);

            return new Bagel();
        }

        public void ApplyCreamCheese(Bagel bagel) => Console.WriteLine("Spreading cream cheese on the bagel.");

        public async Task<AppleJuice> PourAppleJuice()
        {
            Console.WriteLine("Getting the apple juice out of the fridge.");
            await Task.Delay(500);
            Console.WriteLine("Pouring a glass of apple juice.");
            await Task.Delay(1000);
            Console.WriteLine("Putting the apple juice back in the fridge.");

            return new AppleJuice();
        }
    }
}
