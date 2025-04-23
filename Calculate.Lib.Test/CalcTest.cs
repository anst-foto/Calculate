namespace Calculate.Lib.Test;

public class CalcTest
{
    [Fact]
    public void AddTest()
    {
        const double expected = 4;
        var actual = Calc.Add(2, 2);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void SubTest()
    {
        const double expected = 0;
        var actual = Calc.Sub(2, 2);
        
        Assert.Equal(expected, actual);
    }
}