namespace Unit02
{
    public class OutDoor : Event
    {
        private string _weather;

        public void Weather(string weather) { _weather = weather; }

        public string fullDetailsWeather()
        {
            string result = standarDetails();
            string combine = $"{result} Weather: {_weather}";
            return combine;
        }
    }
}