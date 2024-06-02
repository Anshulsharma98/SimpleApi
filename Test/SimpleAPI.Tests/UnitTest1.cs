using SimpleApi;
using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{

    ValuesController values=new ValuesController();  ///AAA here Arange pattern
    [Fact]
    public void Test1()
    {

    }
    
    [Fact]
    public void GetReturnNumbers()
    {
        //Given
        var Getvalues=values.Get(1);    //AAA   Act
        //When
        //Then

        Assert.Equal("Anshul",Getvalues);      /// AAA pattern Assert

        
    }
}