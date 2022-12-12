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
            int dur = duringTime();

            double speed = (distanc / dur) * 60;
            return speed;
        }

        public override double Pace()
        {
            double distanc = distance();
            int dur = duringTime();
            double pace = (dur / distanc);
            return pace;
        }
        public override string GetSummary()
        {
            double distanc = distance();
            double speed = Speed();
            double pace = Pace();
            DateTime date = Date();
            string typeActivity = TypeActivity();
            int during = duringTime();
            Console.WriteLine($"{date} {typeActivity} ({during} min) Distance: {distanc} Speed: {speed} kph Pace: {pace} min per km Laps {_laps}");
            return "";
        }
    }
}