using System;

namespace Unit01
{
    public class Activity
    {
        private DateTime _date;
        private int _duration;
        private double _distance;
        private string _typeActivity;
        

        public DateTime GetDate()
        {
            return _date;
        }
        public int GetDuration()
        {
            return _duration;
        }
        public double GetDistance()
        {
            return _distance;
        }
         public string GetTypeActivity()
        {
            return _typeActivity;
        }
        public void SetDate(DateTime newDate)
        {
            _date = newDate;
        }
        public void SetDuration(int newDuration)
        {
            _duration = newDuration;
        }
        public void SetDistance(double newDistance)
        {
            _distance = newDistance;
        }
        public void SetTypeActivity(string newTypeActivity)
        {
            _typeActivity = newTypeActivity;
        }
         
        
        public virtual double Speed() 
        {
            double speed = (GetDistance() / GetDuration()) * 60;
            return speed;
        }
        
        public virtual double Pace()
        {
            double pace = (GetDuration() / GetDistance());
            return pace;            
        }

        public virtual double distance()
        {
            return GetDistance();
        }

        public virtual string GetSummary()
        {
            return "";
        }
    }
}
