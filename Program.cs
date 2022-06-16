Solution solution = new Solution();

int[] numbers = {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,1};

var result = solution.FindMaxConsecutiveOnes(numbers);

Console.WriteLine(result);

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int count = 0;
        int[] counts = new int[nums.Length + 1];
        int countsIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                count += 1;
            }
            else
            {
                counts[countsIndex] = count;
                countsIndex += 1;
                count = 0;
            }
        }

        counts[countsIndex] = count;

        return counts.Max();
    }
}