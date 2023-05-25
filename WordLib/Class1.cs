namespace WordLib
{
    public class Worder
    {
        public string LengthChecker(string input)
        {
            int numLetters = input.Length;

            return numLetters.ToString();
        }

        public string PalindromeChecker(string input)
        {
            string _inputstr, _reversestr = string.Empty;
            _inputstr = input;


            for (int i = _inputstr.Length - 1; i >= 0; i--)
            {
                _reversestr += _inputstr[i].ToString();
            }
            return _reversestr;
        }
    }
}