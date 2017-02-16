using Xunit;
using ScrabbleApp.Objects;

namespace ScrabbleApp
{
    public class ScrabbleTest
    {
      [Fact]
      public void CalculateScore_SingleLetter_Number()
      {
        //Arrange
        string oneLetter = "n";
        //Act
        Scrabble newWord = new Scrabble(oneLetter);
        //Assert
        Assert.Equal(1, newWord.CalculateScore());
      }
    }

}
