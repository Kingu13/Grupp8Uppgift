using Xunit; 
namespace application.Tests{



public class TestPersonnummer
{ 
    [Theory]
    [InlineData("920101-1234")]
    [InlineData("850214-5678")]
    [InlineData("990630-9876")]
    public void IsValidPersonnummer_ValidFormat_ShouldReturnTrue(string personnummer)
    {
        
      

        // Act
        bool actualResult = Program.IsValidPersonnummer(personnummer);

        // Assert
        Assert.True(actualResult);
    }
    [Theory]
    [InlineData("920101-12")]
    [InlineData("8502145678")]
    [InlineData("abcde")]
    public void IsValidPersonnummer_InvalidFormat_ShouldReturnFalse(string personnummer)
    {
       

        // Act
        bool actualResult = Program.IsValidPersonnummer(personnummer);

        // Assert
        Assert.False(actualResult);
    }
    /*[Theory]
    [InlineData("9A0M01-GAM3")]
    [InlineData("850N14-5HAB")]
    public void IsValidPersonnummer_InvalidCharacter_ShouldReturnFalse(string personnummer)
    {
      

        // Act
        bool actualResult = Program.IsCorrectFormat(personnummer);

        // Assert
        Assert.False(actualResult);

    }*/
    
}
}