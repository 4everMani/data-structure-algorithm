
namespace String;

public class RomanToInteger
{
    public static void Solution(string s)
    {
        System.Console.WriteLine(OptimalSolution(s));
    }

    private static int NaiveSolution(string s)
    {
        var dict = new Dictionary<char, int>();
        dict.Add('I', 1);
        dict.Add('V', 5);
        dict.Add('X', 10);
        dict.Add('C', 100);
        dict.Add('L', 50);
        dict.Add('D', 500);
        dict.Add('M', 1000);

        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i < (s.Length - 1))
            {
                var v = dict[s[i]];
                var k = dict[s[i + 1]];
                if (v < k)
                {
                    result += k - v;
                    i++;
                }
                else result += v;
            }
            else result += dict[s[i]];
        }
        return result;
    }

    private static int OptimalSolution(string s)
    {
        int answer = 0;
        int prev = 0;

        for (int i = s.Length - 1; i >= 0 ; i--)
        {
            int num = GetIntValue(s[i]);
            if (prev > num) answer -= num;
            else answer += num;
            prev = num;
        }
        return answer;

        
    }
    private static int GetIntValue(char s)
    {
        return s switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
            };
    }
}
