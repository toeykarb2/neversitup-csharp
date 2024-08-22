using System.ComponentModel;

namespace Project;

public class CountSmileyTest
{
    [Fact]
    [Description("find perfect smiley [':)', ';(', ';}', ':-D']")]
    public void Case1()
    {
        Assert.Equal(2, CountSmiley.FindSmiley([":)", ";(", ";}", ":-D"]));
        
    }
    [Fact]
    [Description("find perfect smiley [';D', ':-(', ':-)', ';~)']")]
    public void Case2()
    {
        Assert.Equal(3, CountSmiley.FindSmiley([";D", ":-(", ":-)", ";~)"]));
        
    }
    [Fact]
    [Description("find perfect smiley [';D', ':-(', ':-)', ';~)']")]
    public void Case3()
    {
        Assert.Equal(1, CountSmiley.FindSmiley([";]", ":[", ";*", ":$", ";-D"]));
        
    }
    [Fact]
    [Description("find if empty array")]
    public void Case4()
    {
        Assert.Equal(0, CountSmiley.FindSmiley([]));
        
    }
   
}