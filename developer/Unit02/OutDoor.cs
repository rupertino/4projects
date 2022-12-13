namespace Unit02
{
    public class OutDoor : Event
    {
        private string _weather;

        public string GetWeather()
        {
            return _weather;
        }
        public void SetWeather(string newWeather)
        {
            _weather = newWeather;
        }
        
        public string GetFullDetails()
        {
            string fullDetails = "Full Details\r\n";    
            string result = GetStandarDetails();
            string combine = $"{fullDetails}{result}Weather: {_weather}";
            return combine;
        }
    }
}