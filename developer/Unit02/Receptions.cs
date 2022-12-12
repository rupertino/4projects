namespace Unit02
{
    public class Receptions : Event
    {
        private string _register;

        public void Register(string resgister ) { _register = resgister; }

        public string fullDetailsRegister()
        {
            string result = standarDetails();
            string combine = $"{result} Email Register: {_register}";
            return combine;
        }

    }
}