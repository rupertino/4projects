using System;

namespace Unit02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lectures lectures = new Lectures();
            lectures.Title("Reader");
            lectures.Description("Test");
            DateTime date = new DateTime(2003,01,07);
            lectures.Date(date);
            TimeSpan hours = new TimeSpan(6,0,0);
            lectures.Hours(hours);
            lectures.TypeEvent("Lectures");
            lectures.Speaker("Carlos");
            lectures.Limit(2);

            Console.WriteLine("Lecture");
            string standarDetailLecture = lectures.standarDetails();
            Console.WriteLine(standarDetailLecture);
            string fullDetails = lectures.fullDetailsLectures();
            Console.WriteLine(fullDetails);
            string shortDetail = lectures.ShortDetail();
            Console.WriteLine(shortDetail);

            Receptions receptions = new Receptions();

            receptions.Title("Reception");
            receptions.Description("Test");
            DateTime receptionsdate = new DateTime(2003, 01, 07);
            receptions.Date(receptionsdate);
            TimeSpan receptionshours = new TimeSpan(6, 0, 0);
            receptions.Hours(receptionshours);
            receptions.TypeEvent("Reception");
            receptions.Register("testqtest@test.com");

            Console.WriteLine("Reception");
            string standarDetailReception = receptions.standarDetails();
            Console.WriteLine(standarDetailReception);
            string fullDetailsreceptions = receptions.fullDetailsRegister();
            Console.WriteLine(fullDetailsreceptions);
            string shortDetailreceptions = receptions.ShortDetail();
            Console.WriteLine(shortDetailreceptions);

            OutDoor door = new OutDoor();

            door.Title("OutDoor");
            door.Description("Test");
            DateTime doordate = new DateTime(2003, 01, 07);
            door.Date(doordate);
            TimeSpan doorhours = new TimeSpan(6, 0, 0);
            door.Hours(doorhours);
            door.TypeEvent("OutDoor");
            door.Weather("Sunny");

            Console.WriteLine("OutDoor");
            string standarDetaildoor = door.standarDetails();
            Console.WriteLine(standarDetaildoor);
            string fullDetailsdoor = door.fullDetailsWeather();
            Console.WriteLine(fullDetailsdoor);
            string shortDetaildoor = door.ShortDetail();
            Console.WriteLine(shortDetailreceptions);

            Console.ReadLine();
        }       
    }
}
