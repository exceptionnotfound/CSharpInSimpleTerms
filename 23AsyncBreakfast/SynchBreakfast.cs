using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _23AsyncBreakfast
{
public class SynchBreakfast
{
    public Coffee MakeCoffee()
    {
        Console.WriteLine("Starting a pot of coffee");
        Thread.Sleep(8000);
        Console.WriteLine("Pouring a cup of coffee");
        Thread.Sleep(2000);

        return new Coffee();
    }

    public FrenchToast MakeFrenchToast(int count)
    {
        Console.WriteLine($"Putting {count} pieces of bread into the dip.");
        Thread.Sleep(1000);
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Flipping a piece of bread in the dip.");
        }
        Thread.Sleep(1000);

        Console.WriteLine($"Putting {count} pieces of dipped bread into the pan.");
        Thread.Sleep(4000);

        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Flipping a piece of French toast.");
        }

        Thread.Sleep(4000);
        Console.WriteLine("Putting the French toast on the plate.");

        return new FrenchToast();
    }

    public Bacon FryBacon(int count)
    {
        Console.WriteLine($"Putting {count} slices of bacon in the pan.");
        Console.WriteLine("Cooking first side of bacon...");
        Thread.Sleep(3000);
        for(int i = 0; i < count; i++)
        {
            Console.WriteLine("Flipping a piece of bacon");
        }

        Console.WriteLine("Cooking the other side of the bacon.");
        Thread.Sleep(3000);

        Console.WriteLine("Adding the bacon to the plate.");

        return new Bacon();
    }

    public Eggs MakeScrambledEggs()
    {
        Console.WriteLine("Putting oil into a pan.");
        Console.WriteLine("Heating the pan.");
        Thread.Sleep(3000);
        Console.WriteLine("Making the scrambled eggs.");
        Thread.Sleep(8000);
        Console.WriteLine("Putting the eggs on the plate.");

        return new Eggs();
    }

    public Bagel MakeBagel()
    {
        Console.WriteLine("Toasting a bagel");
        Thread.Sleep(7000);

        return new Bagel();
    }

    public void ApplyCreamCheese(Bagel bagel) => Console.WriteLine("Spreading cream cheese on the bagel.");

    public AppleJuice PourAppleJuice()
    {
        Console.WriteLine("Getting the apple juice out of the fridge.");
        Thread.Sleep(500);
        Console.WriteLine("Pouring a glass of apple juice.");
        Thread.Sleep(1000);
        Console.WriteLine("Putting the apple juice back in the fridge.");

        return new AppleJuice();
    }
}
}
