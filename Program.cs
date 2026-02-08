namespace Week4ChallengeLabs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Problem 1");
            Console.WriteLine(ContainsThree(3));
            Console.WriteLine(ContainsThree(140));
            Console.WriteLine(ContainsThree(1111322221));

            Console.WriteLine("Problem 2");
            Console.WriteLine(DivisibleBy2or3(15, 30));
            Console.WriteLine(DivisibleBy2or3(2, 90));
            Console.WriteLine(DivisibleBy2or3(7, 12));

            Console.WriteLine("Problem 3");
            char[] arr1 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(arr1);
            Console.WriteLine(new string(arr1));

            char[] arr2 = new char[] { 'H', 'a', 'n', 'n', 'a', 'h' };
            ReverseString(arr2);
            Console.WriteLine(new string(arr2));

            char[] arr3 = new char[] { 'R', 'A', 'C', 'e', 'c', 'a', 'r' };
            ReverseString(arr3);
            Console.WriteLine(new string(arr3));
        }

        static bool ContainsThree(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }else
                {
                    num /= 10;
                }
            }
            return false;
        }

        static int DivisibleBy2or3(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0) && (num2 % 2 == 0 || num2 % 3 == 0))
            {
                return num1 * num2;
            }
            return num1 + num2;
        }

        static void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;

            }
        }
    }
}
