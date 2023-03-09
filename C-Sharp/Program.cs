namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3-16 --------------------------------
            List<string> words = new List<string>();

            words.Add("First");
            words.Add("Second");
            words.Add("Third");

            // Remember, this is how you print all the items in a list
            words.ForEach(Console.WriteLine);

            RemoveLast(words);
            RemoveLast(words);

            words.ForEach(Console.WriteLine);

            // ----------------------------------------------
        }

        public static void RemoveLast(List<string> words)
        {
            // Exercise 3-16
            if (words.Count > 0)
            {
                words.RemoveAt(words.Count - 1);    
            }
        }

    }
}