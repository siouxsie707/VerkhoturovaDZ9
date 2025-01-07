namespace VerkhoturovaDZ9
{
    public class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    char shiftedChar = char.IsLower(c)
                        ? (char)('z' - (c - 'a'))
                        : (char)('Z' - (c - 'A'));
                    result[i] = shiftedChar;
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }

        public string Decode(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    char shiftedChar = char.IsLower(c)
                        ? (char)('a' + ('z' - c))
                        : (char)('A' + ('Z' - c));
                    result[i] = shiftedChar;
                }
                else
                {
                    result[i] = c;
                }
            }
            return new string(result);
        }
    }
}