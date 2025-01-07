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
                    char shiftedChar;
                    if (char.IsLower(c))
                    {
                        shiftedChar = (char)('я' - (c - 'а')); // сдвижение вниз по алфавиту
                    }
                    else // uppercase letters
                    {
                        shiftedChar = (char)('Я' - (c - 'А'));
                    }
                    result[i] = shiftedChar;
                }
                else
                {
                    result[i] = c; // Если не буква, оставляем без изменений
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
                    char shiftedChar;
                    if (char.IsLower(c))
                    {
                        shiftedChar = (char)('а' + ('я' - c)); // сдвижение вверх по алфавиту
                    }
                    else // uppercase letters
                    {
                        shiftedChar = (char)('А' + ('Я' - c));
                    }
                    result[i] = shiftedChar;
                }
                else
                {
                    result[i] = c; // Если не буква, оставляем без изменений
                }
            }
            return new string(result);
        }
    }
}