using System.Text;

namespace Recursion;

public class DecodingWays
{

    // A message containing letters from A-Z can be encoded into numbers using the following mapping:

    // 'A' -> "1"
    // 'B' -> "2"
    // ...
    // 'Z' -> "26"
    // To decode an encoded message, all the digits must be grouped then mapped back into letters using 
    // the reverse of the mapping above (there may be multiple ways). For example, "11106" can be mapped into:

    // "AAJF" with the grouping (1 1 10 6)
    // "KJF" with the grouping (11 10 6)
    // Note that the grouping (1 11 06) is invalid because "06" cannot be mapped into 'F' 
    //since "6" is different from "06".

    // Given a string s containing only digits, return the number of ways to decode it.
    // The test cases are generated so that the answer fits in a 32-bit integer.

    

    // Example 1:
    // Input: s = "12"
    // Output: 2
    // Explanation: "12" could be decoded as "AB" (1 2) or "L" (12).
    
    // Example 2:
    // Input: s = "226"
    // Output: 3
    // Explanation: "226" could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).
   
    // Example 3:
    // Input: s = "06"
    // Output: 0
    // Explanation: "06" cannot be mapped to "F" because of the leading zero ("6" is different from "06").

    public static void Solution(string encode)
    {
        int length = encode.Length;
        int result = encode[0] == '0' ? 0 : Decoder(encode, length - 1);
        int result2 = encode[0] == '0' ? 0 : DecoderII(encode, 0);
        System.Console.WriteLine("{0}, {1}",result, result2);
    }

    // From N - 1 to 0
    private static int Decoder(string encode, int ind)
    {
        // base condition
        if (ind <= 0) return 1;
        

        int res = 0;

        // Single digit as one character
        if (encode[ind] != '0')
            res = Decoder(encode, ind - 1);

        // two digits as one character
        if ((encode[ind - 1] == '1' && encode[ind] <= '9') || (encode[ind - 1] == '2' && encode[ind] <= '6'))
            res += Decoder(encode, ind - 2);

        return res;    
    }

    private static int DecoderII(string encode, int ind)
    {
        if (ind >= encode.Length - 1) return 1;

        int res = 0;

        if ((encode[ind]) == 0)
        {
            res = DecoderII(encode, ind + 1);
        }
        if ((encode[ind + 1] == '1' && encode[ind] <= '9') || (encode[ind + 1] == '2' && encode[ind] <= '6'))
            res += Decoder(encode, ind + 2);

        return res;    
    }
}
