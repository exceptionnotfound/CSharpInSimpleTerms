using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace _23AsyncBreakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            SynchBreakfast sBreakfast = new SynchBreakfast();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            var coffee = sBreakfast.MakeCoffee();
            var frenchToast = sBreakfast.MakeFrenchToast(4);
            var eggs = sBreakfast.MakeScrambledEggs();
            var bacon = sBreakfast.FryBacon(3);
            var bagel = sBreakfast.MakeBagel();
            sBreakfast.ApplyCreamCheese(bagel);
            var juice = sBreakfast.PourAppleJuice();

            watch.Stop();
            Console.WriteLine("Elapsed milliseconds: " + watch.ElapsedMilliseconds);

            AsyncBreakfast aBreakfast = new AsyncBreakfast();

            Stopwatch asyncWatch = new Stopwatch();
            asyncWatch.Start();

            var coffeeTask = aBreakfast.MakeCoffee();
            var frenchToastTask = aBreakfast.MakeFrenchToast(3);
            var eggsTask = aBreakfast.MakeScrambledEggs();
            var baconTask = aBreakfast.FryBacon(4);
            var bagelTask = aBreakfast.MakeBagel();
            var juiceTask = aBreakfast.PourAppleJuice();

            var completeBagel = await bagelTask;
            aBreakfast.ApplyCreamCheese(completeBagel);

            await Task.WhenAll(coffeeTask, frenchToastTask, eggsTask, baconTask, juiceTask);

            asyncWatch.Stop();
            Console.WriteLine("Elapsed milliseconds: " + asyncWatch.ElapsedMilliseconds);
        }
    }
}
