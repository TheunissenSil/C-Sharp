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
            // Exercise 3-21 --------------------------------
            int[] array = { 5, 1, 3, 4, 2 };
            PrintArrayInStars(array);

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

        public static void PrintArrayInStars(int[] array)
        {
            // Exercise 3-21
            for (int i = 0; i < array.Length; i++)
            {
                String stars = new String('*', array[i]);
                Console.WriteLine(stars);
            }
        }

    }
}