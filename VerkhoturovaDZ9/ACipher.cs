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
                    if ((c == 'я') || (c == 'Я'))
                    {
                        shiftedChar = (c == 'я') ? 'а' : 'А'; // Цикличный сдвиг для «я»
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
                    char shiftedChar = (char)(c - 1);
                    if ((c == 'а') || (c == 'А'))
                    {
                        shiftedChar = (c == 'а') ? 'я' : 'Я'; // Цикличный сдвиг для «а»
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