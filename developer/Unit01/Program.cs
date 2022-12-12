using System;

namespace Unit01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Runnig runnig = new Runnig();
            runnig.Distance(4.8);
            runnig.DuringTime(30);
            runnig.Date(DateTime.Now);
            runnig.TypeActivity("Running");
            runnig.GetSummary();


            cycling cycling = new cycling();
            cycling.Distance(100);
            cycling.DuringTime(30);
            cycling.Date(DateTime.Now);
            cycling.TypeActivity("Cycling");
            cycling.GetSummary();

            Swimming swimming = new Swimming();
            swimming.Laps(1000);
            swimming.Distance(10);
            swimming.DuringTime(60);
            swimming.Date(DateTime.Now);
            swimming.TypeActivity("Swimming");
            swimming.GetSummary();


            Console.ReadLine();
            



        }
    }
}