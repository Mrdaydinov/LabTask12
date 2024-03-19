namespace LabTasks12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //    Console.WriteLine("Enter number:");
            //input:
            //    bool check = int.TryParse(Console.ReadLine(), out int input);
            //    if (!check)
            //    {
            //        Console.WriteLine("Not number");
            //        goto input;
            //    }



            //    Console.WriteLine(ReverseNum(input));

            // Task 2

            Console.WriteLine(IsSimple(Sum(Fibonacci())));
        }

        static int ReverseNum(int input)
        {
            int temp = input;
            int count = 0;
            int lastDig;
            int firstDig;

            while (temp > 0)
            {
                temp /= 10;
                count++;
            }


            int baseNumber = 10;
            int exponent = count - 1;
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }


            int res = 0;
            for (int i = 0; i < count; i++)
            {
                lastDig = input % 10 * result;
                input /= 10;
                result /= 10;
                res += lastDig;
            }

            return res;
        }


        static int[] Fibonacci()
        {

            int[] res = new int[20];
            int num = 0;
            int temp = 1;
            int temp2 = 0;
            for (int i = 0; i < 100; i++)
            {
                if (num > 100)
                    break;
                res[i] = num;
                num += temp;
                temp = temp2;
                temp2 = num;
            }

            return res;
        }

        static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
                sum += num;
            return sum;
        }

        static bool IsSimple(int num)
        {
            bool result = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i != 0)
                    result = false;
            }

            return result;
        }
    }
}
