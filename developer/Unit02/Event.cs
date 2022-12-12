using System;

namespace Unit02
{
    public class Event
    {
        private string _title;
        private string _description;
        private DateTime _date;
        private TimeSpan _hours;
        private string _typeEvent;


        public void Title(string title) { _title = title; }
        public void Description(string description) { _description = description; }
        public void Date(DateTime date) { _date = date; }
        public void Hours(TimeSpan hours) { _hours = hours; }
        public void TypeEvent(string typeEvent) { _typeEvent = typeEvent; }

        public string standarDetails() => $"Title: {_title} Description: {_description} Date: {_date.ToString()} Hours: {_hours.ToString()} ";
        public string ShortDetail() => $"Type Event: {_typeEvent} Title: {_title}  Date: {_date.ToString()} ";
        
    }
}
