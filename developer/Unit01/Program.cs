using System;

namespace Unit01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Runnig runnig = new Runnig();
            runnig.SetDistance(4.8);
            runnig.SetDuration(30);
            runnig.SetDate(DateTime.Now);
            runnig.SetTypeActivity("Running");
            runnig.GetSummary();

            cycling cycling = new cycling();
            cycling.SetDistance(100);
            cycling.SetDuration(30);
            cycling.SetDate(DateTime.Now);
            cycling.SetTypeActivity("Cycling");
            cycling.GetSummary();

            Swimming swimming = new Swimming();
            swimming.Laps(1000);
            swimming.SetDistance(10);
            swimming.SetDuration(60);
            swimming.SetDate(DateTime.Now);
            swimming.SetTypeActivity("Swimming");
            swimming.GetSummary();

            Console.ReadLine();            
        }
    }
}