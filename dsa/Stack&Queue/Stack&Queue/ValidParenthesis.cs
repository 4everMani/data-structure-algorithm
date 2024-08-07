namespace Stack_Queue;

public class ValidParenthesis
{
    // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    // An input string is valid if:
    // Open brackets must be closed by the same type of brackets.
    // Open brackets must be closed in the correct order.
    // Every close bracket has a corresponding open bracket of the same type.
    

    // Example 1:
    // Input: s = "()"
    // Output: true
    
    // Example 2:
    // Input: s = "()[]{}"
    // Output: true
    
    // Example 3:
    // Input: s = "(]"
    // Output: false




    // Approach: 

    // Whenever we get the opening bracket we will push it into the stack. I.e ‘{‘, ’[’, ’(‘.
    // Whenever we get the closing bracket we will check if the stack is non-empty or not.
    // If the stack is empty we will return false, else if it is nonempty then we will check if the topmost element of the stack is the opposite pair of the closing bracket or not.
    // If it is not the opposite pair of the closing bracket then return false, else move ahead.
    // After we move out of the string the stack has to be empty if it is non-empty then return it as invalid else it is a valid string.
    
    public bool IsValid(string s) {
        var dict = new Dictionary<char, char>();
        dict.Add(')', '(');
        dict.Add('}', '{');
        dict.Add(']', '[');
        var s1 = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsValue(s[i]))
            {
                s1.Push(s[i]);
            }
            else
            {
                if (s1.Count == 0) return false;
                var top = s1.Pop();
                if (top != dict[s[i]]) return false;  
            }
        }
        return s1.Count == 0;
    }
}
