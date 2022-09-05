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
                                  "3) Insertion Sort\n");
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
                }
            }
        }
    }
}