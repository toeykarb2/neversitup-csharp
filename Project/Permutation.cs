
public class Permutation
{
    private static List<string> NextPermutation(String str, int l, int r, List<string> result)
    {
        if (l == r && result.IndexOf(str) == -1){
            result.Add(new string(str));
        }
           
        else
        {
            for (int i = l; i <= r; i++)
            {
                str = Swap(str, l, i);
                NextPermutation(str, l + 1, r, result);
                str = Swap(str, l, i);
            }
        }
        return result;
    }

    public static String Swap(String a, int i, int j)
    {
        char temp;
        char[] charArray = a.ToCharArray();
        temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        string s = new string(charArray);
        return s;
    }

    public static List<string> GeneratePermutations(string input)
    {
        var result = new List<string>();
        int n = input.Length;
        NextPermutation(input, 0, n - 1, result);
        return result;
    }
}


// class Permutation {
//     public static List<string> GeneratePermutations(String input)
//     {
//         var array = input.ToArray();
//         Span<char> spanInput = array.AsSpan();
//         var result = new List<string>() { new string(spanInput) };
//         while (NextPermutation(spanInput)){
//             result.Add(new string(spanInput));
//         }

//         return result;
//     }

//     public static bool NextPermutation(Span<char> input)
//     {
//         int i = input.Length - 2;
//         while (i >= 0 && input[i] >= input[i + 1])
//         {
//             i--;
//         }
//         if (i < 0){
//             return false;
//         }
//         int j = input.Length - 1;
//         while (input[j] <= input[i])
//         {
//             j--;
//         }
//         (input[i], input[j]) = (input[j], input[i]);
//         Shufflings(input, i + 1);
//         return true;
//     }

//     private static void Shufflings(Span<char> input, int start)
//     {
//         int i = start;
//         int j = input.Length - 1;
//         while (i < j)
//         {
//             (input[i], input[j]) = (input[j], input[i]);
//             i++;
//             j--;
//         }
//     }

// }