namespace Unit02
{
    public class Receptions : Event
    {
        private string _register;

        public string GetRegister()
        {
            return _register;
        }

        public void SetRegister(string newRegister)
        {
            _register = newRegister;
        }    

        public string GetFullDetails()
        {
            string result = "Full Details \r\n" 
            + GetStandarDetails();
            string combine = $"{result}Email Register: {GetRegister()}";
            return combine;
        }
    }
}