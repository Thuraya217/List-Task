namespace List_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("\nSelect a Program:");
                    Console.WriteLine("1. Top N Frequent Numbers");
                    Console.WriteLine("2. Palindrome Filter");
                    Console.WriteLine("3. Shift List Elements");
                    Console.WriteLine("4. Unique Words Extractor");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: TopNFrequentNumbers(); break;
                        case 2: PalindromeFilter(); break;
                        case 3: ShiftListElements(); break;
                        case 4: UniqueWordsExtractor(); break;
                        case 0: return;
                        default: Console.WriteLine("Invalid Choice! Try again."); break;
                    }
                    Console.ReadLine();
                }
            }

            // Creating a list 
            static void TopNFrequentNumbers()
            {
                List<int> numbers = new List<int> { 40, 50, 60, 10, 70, 10, 50, 90, 50, 90 }; //  create list, Adding multiple elements 

                List<int> uniqueNumbers = new List<int>(); // To track unique values
                List<int> counts = new List<int>(); // To track how many times each appears
                  
                // Count frequency of each unique number
                for (int i = 0; i < numbers.Count; i++)
                {
                    int current = numbers[i];
                    int index = uniqueNumbers.IndexOf(current);

                    if (index == -1)
                    {
                        uniqueNumbers.Add(current);
                        counts.Add(1);
                    }
                    else
                    {
                        counts[index]++;
                    }
                }

                int N = 1;
                // Find top N frequent numbers
                for (int i = 0; i < N; i++)
                {
                    if (counts.Count == 0)
                        break;

                    int maxIndex = 0;
                    for (int j = 1; j < counts.Count; j++)
                    {
                        if (counts[j] > counts[maxIndex])
                        {
                            maxIndex = j;
                        }
                    }
                    Console.WriteLine($"The frequent number is: {uniqueNumbers[maxIndex]}");

                }
            }

            static void PalindromeFilter()
            {

                List<int> numbers = new List<int>();


            }

            static void ShiftListElements()
            {

                List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
                int k = 2;

            }

            static void UniqueWordsExtractor()
            {

            }
        }
    }
}
