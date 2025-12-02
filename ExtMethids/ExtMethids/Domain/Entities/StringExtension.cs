namespace ExtMethids.Domain.Entities
{
    public static class StringExtension
    {
        public static string CountOfVowelsAndConsonantsInString(this string str)
        {
            int Vcount = 0;
            int Ccount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.ToLower(str[i]) == 'a'|| Char.ToLower(str[i]) == 'e'|| Char.ToLower(str[i]) == 'i'|| Char.ToLower(str[i]) == 'o'|| Char.ToLower(str[i]) == 'u')
                {
                    Vcount++;
                }
                else if (Char.ToLower(str[i]) >= 'a' && Char.ToLower(str[i]) <= 'z')
                {
                    Ccount++;
                }
            }
            return $"Vowels:{Vcount}\nConsonats:{Ccount}";

        }
        public static int CountOfSubjectsInString(this string str)
        {
            int count = 0;
            for(int i = 0;i < str.Length;i++)
            {
                if (str[i] == '.' || str[i] == '!' || str[i] == '?')
                {
                    count++;
                }
            }
            return count;
        }
        public static int CountOfWordsInString(this string str)
        {
            int count = 0;

        }

    }
}
