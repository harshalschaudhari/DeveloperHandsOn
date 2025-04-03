namespace CharacterFrequency
{
    class Program
    {
        public static void Main()
        {
            string word = "Mississippi";
            char ch = 's';
            int frequency = returnCharacterFrequency(word, ch);
            Console.WriteLine($"Word: '{word}' has the character '{ch}' with a frequency of {frequency}.");
            Console.ReadKey();
        }

        public static int returnCharacterFrequency(string word, char ch)
        {
            int frequency = 0;
            for(int index = 0; index < word.Length; index++)
            {
                if(word[index] == ch)
                {
                    frequency++;
                }
            }
            return frequency;
        }
    }
}
