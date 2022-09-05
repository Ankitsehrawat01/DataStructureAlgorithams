using DataSttructureAlgorithams;

namespace DataStructureAlgorithams
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Welcome To Datastructures and Algorithms");
                Console.WriteLine("1) Permutation of string Using Recursion\n" +
                                  "2) BinarySearch of a word from Text File\n" +
                                  "3) Insertion Sort\n" +
                                  "4) Bubble Sorting\n" +
                                  "5) Merge Sort\n" +
                                  "6) Anagram Detection Program\n" +
                                  "7) Prime Numbers between 0 - 1000\n");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        StringPermutation stringobj = new StringPermutation();
                        stringobj.permutations();
                        break;
                    case 2:
                        BinarySearchWord binarysearchobj = new BinarySearchWord();
                        binarysearchobj.binarySearch();
                        break;
                    case 3:
                        InsertionSort insertionsortobj = new InsertionSort();
                        insertionsortobj.insertionSort();
                        break;
                    case 4:
                        BubbleSort bubblesortobj = new BubbleSort();
                        bubblesortobj.bubbleSort();
                        break;
                    case 5:
                        MergeSort mergetobj = new MergeSort();
                        Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
                        Console.Write("\n\nEnter number of elements: ");
                        int max = Convert.ToInt32(Console.ReadLine());
                        int[] numbers = new int[max];
                        for (int i = 0; i < max; i++)
                        {
                            Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Write("Input int array : ");
                        Console.Write("\n");
                        for (int k = 0; k < max; k++)
                        {
                            Console.Write(numbers[k] + " ");
                            Console.Write("\n");
                        }
                        Console.WriteLine("MergeSort By Recursive Method");
                        mergetobj.SortMerge(numbers, 0, max - 1);
                        for (int i = 0; i < max; i++)
                            Console.WriteLine(numbers[i]);
                        Console.ReadLine();
                        break;
                    case 6:
                        Anagrams anagrams = new Anagrams();
                        anagrams.checkAnagrams();
                        break;
                    case 7:
                        PrimeNumber primenumbersobj = new PrimeNumber();
                        primenumbersobj.Numbers();
                        break;
                }
            }
        }
    }
}