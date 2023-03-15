namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 3-16 --------------------------------
            //List<string> words = new List<string>();

            //words.Add("First");
            //words.Add("Second");
            //words.Add("Third");

            //words.ForEach(Console.WriteLine);

            //RemoveLast(words);
            //RemoveLast(words);

            //words.ForEach(Console.WriteLine);

            // ----------------------------------------------
            // Exercise 3-21 --------------------------------
            //int[] array = { 5, 1, 3, 4, 2 };
            //PrintArrayInStars(array);

            // ----------------------------------------------
            // Exercise 3-28 --------------------------------
            //Opd3_28();

            // ----------------------------------------------
            // Exercise 3-29 --------------------------------
            //Opd3_29();

            // ----------------------------------------------
            // Exercise 3-30 --------------------------------
            //Opd3_30();

            // ----------------------------------------------
            // Exercise 3-31 --------------------------------
            //Opd3_31();

            // ----------------------------------------------
            // Exercise 4-21 --------------------------------
            //Opd4_21();

            // ----------------------------------------------
            // Exercise 4-22 --------------------------------
            //Opd4_22();

            // ----------------------------------------------
            // Exercise 4-23 --------------------------------
            //Opd4_23();

            // ----------------------------------------------
            // Exercise 4-24 --------------------------------
            Opd4_24();

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

        public static void Opd3_28()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(' ');
                    if (parts.Length > 0)
                    {
                        Console.WriteLine(parts[parts.Length - 1]);
                    }
                }
            }
        }

        public static void Opd3_29()
        {
            int maxAge = 0;
            bool isFirstInput = true;

            while (true)
            {
                Console.Write("Enter name and age (or empty line to quit): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int age))
                    {
                        Console.WriteLine("Name: " + parts[0] + ", Age: " + age);
                        if (isFirstInput)
                        {
                            maxAge = age;
                            isFirstInput = false;
                        }
                        else if (age > maxAge)
                        {
                            maxAge = age;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter name and age separated by a comma.");
                    }
                }
            }

            Console.WriteLine("Age of the oldest: " + maxAge);
        }

        public static void Opd3_30()
        {
            String name = "";
            int maxAge = 0;
            bool isFirstInput = true;

            while (true)
            {
                Console.Write("Enter name and age (or empty line to quit): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int age))
                    {
                        Console.WriteLine("Name: " + parts[0] + ", Age: " + age);
                        if (isFirstInput)
                        {
                            name = parts[0];
                            maxAge = age;
                            isFirstInput = false;
                        }
                        else if (age > maxAge)
                        {
                            name = parts[0];
                            maxAge = age;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter name and age separated by a comma.");
                    }
                }
            }

            Console.WriteLine("Name of the oldest: " + name);
        }

        public static void Opd3_31()
        {
            String name = "";
            int maxAge = 0;
            bool isFirstInput = true;
            bool isFirstInputName = true;

            while (true)
            {
                Console.Write("Enter name and age (or empty line to quit): ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    string[] parts = input.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int age))
                    {
                        Console.WriteLine("Name: " + parts[0] + ", Age: " + age);
                        if (isFirstInput)
                        {
                            maxAge = age;
                            isFirstInput = false;
                        }
                        else if (age < maxAge)
                        {
                            maxAge = age;
                        }

                        if (isFirstInputName)
                        {
                            isFirstInputName = false;
                            name = parts[0];
                        }
                        else if (parts[0].Length > name.Length)
                        {
                            name = parts[0];
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter name and age separated by a comma.");
                    }
                }
            }

            maxAge = 2023 - maxAge;

            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + maxAge);
        }

        public static void Opd4_21()
        {
            List<Book> books = new List<Book>();

            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name)) break;

                Console.Write("Pages: ");
                int pages = int.Parse(Console.ReadLine());

                Console.Write("Publication year: ");
                int year = int.Parse(Console.ReadLine());

                books.Add(new Book(name, pages, year));
            }

            Console.Write("What information will be printed? ");
            string printOption = Console.ReadLine().ToLower();

            switch (printOption)
            {
                case "everything":
                    foreach (Book book in books)
                    {
                        Console.WriteLine(book.ToString());
                    }
                    break;
                case "title":
                    foreach (Book book in books)
                    {
                        Console.WriteLine(book.Title);
                    }
                    break;
                default:
                    break;
            }
        }

        public static void Opd4_22()
        {
            int count = 0;

            Console.WriteLine("Input a string: ");

            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) Console.WriteLine("This is not a valdid string!");

                if (input == "end")
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            Console.WriteLine(count);

        }

        public static void Opd4_23()
        {
            int count = 0;

            Console.WriteLine("Input a string: ");

            while (true)
            {
                string input = Console.ReadLine();

                int.TryParse(input, out int number);

                if (string.IsNullOrWhiteSpace(input)) Console.WriteLine("This is not a valdid string!");

                if (input == "end")
                {
                    break;
                }
                else
                {
                    number = number * number * number;
                    Console.WriteLine(number);
                }
            }

            Console.WriteLine("end");

        }

        public static void Opd4_24()
        {
            string filePath = "C:\\Users\\theun\\OneDrive - ROC Nijmegen\\Documenten\\ROC\\Leerjaar 2\\C#\\C-Sharp\\C-Sharp\\Data.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine($"File {filePath} not found.");
            }
        }
    }
}