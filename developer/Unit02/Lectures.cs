namespace Unit02
{
    public class Lectures : Event
    {
        private string _speaker;
        private int _limit;

        public string GetSpeaker()
        {
            return _speaker;
        }
        public int GetLimit()
        {
            return _limit;
        }

        public void SetSpeaker(string newSpeaker)
        {
            _speaker = newSpeaker;
        }

        public void SetLimit(int newLimit)
        {
            _limit = newLimit;
        }
        
        public string GetFullDetails() 
        {
            string result = "Full Details \r\n" 
            + GetStandarDetails();

            string combine = $"{result}Speaker: {_speaker} Limit: {_limit}";
            return combine;
        }
    }
}
