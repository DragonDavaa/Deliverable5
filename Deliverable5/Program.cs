//Author: Davaanyam Baljinnyam
//Date: 2/9/2023
//Description: Deliverable 5

namespace Deliverable5
{
    internal class Program
    {
        static int[] Method1(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int Method2(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum = sum + i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Boolean done = false;

            while (!done)
            {
                try
                {
                    while (true)
                    {
                        Console.WriteLine("Enter an integer number between 5 and 15");
                        int input = int.Parse(Console.ReadLine());
                        int[] MyArray = Method1(input);

                        if (input >= 5 && input <= 15)
                        {
                            Console.Write("The elements in the random array are: ");
                            foreach (int i in MyArray)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("The sum is : " + Method2(MyArray));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please make sure to enter interger between 5 and 15!!!");
                        }

                    }
                    done = true;

                }
                catch
                {
                    Console.WriteLine("The data type you entered is not an integer between 5 and 15!!!");
                }
            }
        }
    }
}