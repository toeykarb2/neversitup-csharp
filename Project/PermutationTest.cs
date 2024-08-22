using System.ComponentModel;

namespace Project;

public class PermutationTest
{
    [Fact]
    [Description("find the permutations of a")]
    public void Case1()
    {
        Assert.Equal(["a"], Permutation.GeneratePermutations("a"));

    }
    [Fact]
    [Description("find the permutations of ab")]
    public void Case2()
    {
        Assert.Equal(["ab", "ba"], Permutation.GeneratePermutations("ab"));

    }
    [Fact]
    [Description("find the permutations of abc")]
    public void Case3()
    {
        Assert.Equal(["abc", "acb", "bac", "bca", "cba", "cab"], Permutation.GeneratePermutations("abc"));

    }

    [Fact]
    [Description("find the permutations of 'aabb'")]
    public void Case4()
    {
        Assert.Equal(["aabb", "abab", "abba", "baab", "baba", "bbaa"], Permutation.GeneratePermutations("aabb"));

    }
    
}