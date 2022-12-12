using System;

namespace Unit01
{
    public class Runnig: Activity
    {  
        public override string GetSummary() 
        {
            double distanc = GetDistance();
            double speed = Speed();
            double pace = Pace();
            DateTime date = GetDate();
            string typeActivity = GetTypeActivity();
            int during = GetDuration();
            Console.WriteLine($"{date} {typeActivity} ({during} min) Distance: {distanc} Speed: {speed} kph Pace: {pace} min per km");
            return "";
        }
       
    }
}
