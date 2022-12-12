using System;

namespace Unit01
{
    public class Activity
    {
        private DateTime _date;
        private int _duringTime;
        private double _distance;
        private string _typeActivity;
        

        public void TypeActivity(string typeActivity) { _typeActivity = typeActivity; }
        public void Date(DateTime date) { _date = date; }
        public void DuringTime(int duringTime) { _duringTime = duringTime; }
        public void Distance(double distance) { _distance = distance; }

        public virtual DateTime Date() => _date;

        public virtual string TypeActivity() => _typeActivity;
        
        public virtual int duringTime() => _duringTime;        

        public virtual double Speed() 
        {
            double speed = (_distance / _duringTime) * 60;
            return speed;
        }

        public virtual double Pace()
        {
            double pace = (_duringTime / _distance);
            return pace;            
        }

        public virtual double distance()
        {
            return _distance;
        }

        public virtual string GetSummary()
        {
            return "";
        }
    }
}
