
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