namespace LabTasks12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number:");
        input:
            bool check = int.TryParse(Console.ReadLine(), out int input);
            if (!check)
            {
                Console.WriteLine("Not number");
                goto input;
            }


            
            Console.WriteLine(ReverseNum(input));

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
    }
}
