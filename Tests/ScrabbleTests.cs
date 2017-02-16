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
        string oneLetter = "z";
        //Act
        Scrabble newWord = new Scrabble(oneLetter);
        //Assert
        Assert.Equal(10, newWord.CalculateScore());
      }

    [Fact]
    public void CalculateScore_MultipleLetters_Number()
    {
      //Arrange
      string multipleLetters = "dog";
      //Act
      Scrabble newWord = new Scrabble(multipleLetters);
      //Assert
      Assert.Equal(5, newWord.CalculateScore());
    }
  }
}
