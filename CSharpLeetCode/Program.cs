namespace CSharpLeetCode
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello, World!");
            //TwoSum([3, 2, 4]);
            Console.WriteLine(IsPalindromeWithoutStringCast(723414327).ToString());
        }

        public static bool IsPalindromeWithoutStringCast(int x)
        {
            if (x <= 0)
            {
                if (x == 0)
                {
                    return true;
                }
                return false;
            }

            // %10 gives the last digit of a number
            // <= 2147483647 therefore, 10 digits max
            List<int> digits = [];

            for(int i = 0; i < 10; i++)
            {
                if(x >= 10)
                {
                    digits.Add(x % 10);
                    x = (int)Math.Floor((double)x / 10);
                }
                else 
                {
                    digits.Add(x);
                    break; 
                }
            }

            int halfish = (int)Math.Floor((double)digits.Count / 2);

            for ((int, int) i = (0, 1); i.Item1 <= halfish; i.Item1 += 1, i.Item2 += 1)
            {
                if (digits[i.Item1] != digits[^i.Item2])
                {
                    return false;
                }
            }
            return true;

        }

        public static bool IsPalindrome(int x)
        {
            // Given an integer x, return true if x is a palindrome, and false otherwise.
            // 121 reads 121 when read left to right and right to left for example
            // Negatives are not palindromes because of the (-)

            // Constraints are safe assumptions we can make (or just facts about the input)
            if(x <= 0)
            {
                if(x == 0)
                {
                    return true;
                }
                return false;
            }

            // x >= 0... all other cases are accounted for
            int[] digits = [.. x.ToString().ToCharArray().Select(i => (i - '0'))];
            int halfish = (int)Math.Floor((double)digits.Length / 2);
            for ((int, int) i = (0, 1); i.Item1 <= halfish; i.Item1 += 1 , i.Item2 += 1)
            {
                if (digits[i.Item1] != digits[^i.Item2])
                {
                    return false;
                }
            }
            return true;
        }
        
        public static int[] TwoSum(int[] nums, int target = 6)
        {
            // num[x] + num[y] = target
            // return int[] = [x, y]

            for (int i = 0; i < nums.Length; i++) // Review arrays vs. lists and the functions(?) they use
            {
                for (int j = nums.Length - 1; j < nums.Length && j != i; j--) // Make sure you account for all business rules and check afterwards
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j]; // Review collection expressions
                    }
                }
            }
            return null!;
        }
    }
}
