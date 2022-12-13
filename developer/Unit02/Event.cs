using System;

namespace Unit02
{
    public class Event
    {
        private string _title;
        private string _description;
        private string _date;
        private string _hours;
        private string _typeEvent;

        public string GetTitle()
        {
            return _title;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetDate()
        {
            return _date;
        }
        public string GetHours()
        {
            return _hours;
        }
        public string GetTypeEvent()
        {
            return _typeEvent;
        }

        public void SetTitle(string newTitle)
        {
            _title = newTitle;
        }
        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public void SetDate(string newDate)
        {
            _date = newDate;
        }
        public void SetHours(string newHours)
        {
            _hours = newHours;
        }
        public void SetTypeEvent(string newTypeEvent)
        {
            _typeEvent = newTypeEvent;
        }
 
        public string GetShortDetails()
        {
            return
            "\r\n" +
            "Short Details - " +
            "Type of Event: " + GetTypeEvent() + ", "
            +"Title: " + GetTitle() + ", "
            +"Date: " + GetDate() + "\r\n"
            ;
        }

        public string GetStandarDetails()
        {
            return 
            "Type of event: " + GetTypeEvent() + Environment.NewLine 
            + "Title: " + GetTitle() + Environment.NewLine 
            + "Description: " + GetDescription() + Environment.NewLine 
            + "Date: " + GetDate() + " " + "Hours: " + GetHours() + Environment.NewLine; 
        }
    }
}
