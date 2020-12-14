using System;
using System.Threading.Tasks;

namespace _23AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var task = Task.Run(() =>
            {
                Console.WriteLine("This is a task running.");
                int sum = 54 + 91;
                Console.WriteLine("Sum is " + sum);
            });

            var isComplete = task.IsCompleted;

            var taskWithReturn = Task.Run(() =>
            {
                Console.WriteLine("This is a task that will return a value.");
                return 54 + 91;
            });

            await task;

            int result = await taskWithReturn;

            Console.WriteLine("The returned value is " + result);


            CatFacts factsAPI = new CatFacts();
            var fact = await factsAPI.GetRandomFact();
            Console.WriteLine("Fact: " + fact.text);

            //Let's get multiple facts
            var fact1 = await factsAPI.GetRandomFact();
            var fact2 = await factsAPI.GetRandomFact();
            var fact3 = await factsAPI.GetRandomFact();

            //However, the above is no better than a synchronous call.
            //Instead, let's instantiate the tasks and wait for all of them to be done.

            Task<CatFact> factTask1 = factsAPI.GetRandomFact();
            Task<CatFact> factTask2 = factsAPI.GetRandomFact();
            Task<CatFact> factTask3 = factsAPI.GetRandomFact();

            await Task.WhenAll(factTask1, factTask2, factTask3);

            CatFact result1 = await factTask1;
            CatFact result2 = await factTask2;
            CatFact result3 = await factTask3;

            Console.WriteLine(result1.text);
            Console.WriteLine(result2.text);
            Console.WriteLine(result3.text);

            //We can also use Task.WhenAny() when we want to proceed if only one task is marked complete.

            Task<CatFact> factTask4 = factsAPI.GetRandomFact();
            Task<CatFact> factTask5 = factsAPI.GetRandomFact();
            Task<CatFact> factTask6 = factsAPI.GetRandomFact();

            await Task.WhenAny(factTask1, factTask2, factTask3);

            CatFact result4 = await factTask4;
            CatFact result5 = await factTask5;
            CatFact result6 = await factTask6;

            Console.WriteLine(result4.text);
            Console.WriteLine(result5.text);
            Console.WriteLine(result6.text);

            Console.ReadLine();
        }
    }
}
