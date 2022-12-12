using System;

namespace Unit01
{
    public class Swimming: Activity
    {
        private int _laps;

        public void Laps(int laps) { _laps = laps; }

        public override double distance()
        {
            double result = _laps * 50 / 1000;
            return result;
        }

        public override double Speed()
        {
            double distanc = distance();
            int dur = GetDuration();

            double speed = (distanc / dur) * 60;
            return speed;
        }

        public override double Pace()
        {
            double distanc = GetDistance();
            int dur = GetDuration();
            double pace = (dur / distanc);
            return pace;
        }
        public override string GetSummary()
        {
            double distanc = GetDistance();
            double speed = Speed();
            double pace = Pace();
            DateTime date = GetDate();
            string typeActivity = GetTypeActivity();
            int during = GetDuration();
            Console.WriteLine($"{date} {typeActivity} ({during} min) Distance: {distanc} Speed: {speed} kph Pace: {pace} min per km Laps {_laps}");
            return "";
        }
    }
}