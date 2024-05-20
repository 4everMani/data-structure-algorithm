
namespace String;

public class ComputeHashValue
{
    public static void Solution(string s)
    {
        System.Console.WriteLine(ComputeHash(s));
    }

    private static long ComputeHash(string s)
    {
        long p = 1;
        long hash = 0;
        double mod = 1e9 + 7;

        // considering a = 1, b = 2, c = 3
        // and formula for this is (s[i] - 'a' + 1)
        for (int i = 0; i < s.Length; i++)
        {
            hash = (long)((hash + ((s[i] - 'a' + 1)*p) % mod)%mod);
            p = (long)((p * 31) % mod);
        }
        return hash;
    }
}
