using System;

namespace Unit01
{
    public class cycling : Activity
    {
        public override string GetSummary()
        {
            double distanc = distance();
            double speed = Speed();
            double pace = Pace();
            DateTime date = Date();
            string typeActivity = TypeActivity();
            int during = duringTime();
            Console.WriteLine($"{date} {typeActivity} ({during} min) Distance: {distanc} Speed: {speed} kph Pace: {pace} min per km");
            return "";
        }
    }
}
