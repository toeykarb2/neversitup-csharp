using System.ComponentModel;

namespace Project;

public class FindOddIntTest
{
    [Fact]
    [Description("find the odd int [7]")]
    public void Case1()
    {
        // find the odd int [7]
        Assert.Equal(7, FindOddInt.FindValue([7]));
        
    }
    [Fact]
    [Description("find the odd int [0]")]
    public void Case2()
    {
        // find the odd int [0]
        Assert.Equal(0, FindOddInt.FindValue([0]));
        
    }
    [Fact]
    [Description("find the odd int [1,1,2]")]
    public void Case3()
    {
        // find the odd int [1,1,2]
        Assert.Equal(2, FindOddInt.FindValue([1,1,2]));
        
    }
    [Fact]
    [Description("find the odd int [0,1,0,1,0]")]
    public void Case4()
    {
        // find the odd int [0,1,0,1,0]
        Assert.Equal(0, FindOddInt.FindValue([0,1,0,1,0]));
        
    }
    [Fact]
    [Description("find the odd int [1,2,2,3,3,3,4,3,3,3,2,2,1]")]
    public void Case5()
    {
        // find the odd int [1,2,2,3,3,3,4,3,3,3,2,2,1]
        Assert.Equal(4, FindOddInt.FindValue([1,2,2,3,3,3,4,3,3,3,2,2,1]));
        
    }
}