using System;

namespace Unit02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lectures lectures = new Lectures();
            lectures.SetTypeEvent("Lecture");
            lectures.SetTitle("12 Rules of Life");
            lectures.SetDescription("Analysis of the chapter 1 of the book.");
            lectures.SetDate("December 18, 2022");
            lectures.SetHours("7:00pm");
            lectures.SetSpeaker("Carlos Gonzalez");
            lectures.SetLimit(15);

            Console.WriteLine("Standar Details");
            Console.WriteLine(lectures.GetStandarDetails());
            Console.WriteLine(lectures.GetFullDetails());
            Console.WriteLine(lectures.GetShortDetails());

            Receptions receptions = new Receptions();
            receptions.SetTypeEvent("Reception");
            receptions.SetTitle("Victoria and Leos Wedding");
            receptions.SetDescription("We are happy to share with you this moment of joy in our lives.");
            receptions.SetDate("January 1, 2023");
            receptions.SetHours("5:00pm");
            receptions.SetRegister("veronica@test.com");

            Console.WriteLine("Standar Details");
            Console.WriteLine(receptions.GetStandarDetails());
            Console.WriteLine(receptions.GetFullDetails());
            Console.WriteLine(receptions.GetShortDetails());

            OutDoor outdoor = new OutDoor();
            outdoor.SetTypeEvent("Outdoor");
            outdoor.SetTitle("Trail walk in Colorado Hill");
            outdoor.SetDescription("Come and enjoy the nature in this beatuful spot.");
            outdoor.SetDate("February 10, 2023");
            outdoor.SetHours("8:00am");
            outdoor.SetWeather("Sunny");

            Console.WriteLine("Standar Details");
            Console.WriteLine(outdoor.GetStandarDetails());
            Console.WriteLine(outdoor.GetFullDetails());
            Console.WriteLine(outdoor.GetShortDetails());
            
            Console.ReadLine();
        }       
    }
}
