namespace VerkhoturovaDZ9
{
    public class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsLetter(c))
                {
                    char shiftedChar = (char)(c + 1);
                    if (char.IsLower(c) && shiftedChar > 'z')
                    {
                        shiftedChar = 'a';
                    }
                    if (char.IsUpper(c) && shiftedChar > 'Z')
                    {
                        shiftedChar = 'A';
                    }
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
                    char shiftedChar = (char)(c - 1);
                    if (char.IsLower(c) && shiftedChar < 'a')
                    {
                        shiftedChar = 'z';
                    }
                    if (char.IsUpper(c) && shiftedChar < 'A')
                    {
                        shiftedChar = 'Z';
                    }
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