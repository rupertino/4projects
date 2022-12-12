namespace Unit02
{
    public class Lectures : Event
    {
        private string _speaker;
        private int _limit;

        public void Speaker(string speaker) { _speaker = speaker; }
        public void Limit(int limit) { _limit = limit; }

        public string fullDetailsLectures() 
        {
            string result = standarDetails();

            string combine = $"{result} Speaker: {_speaker} Limit: {_limit}";
            return combine;
        }
    }
}
