using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReviewTests;

public class UnitTest1
{

    //challenge1
    [Fact]
    public void TestInputNumbers()
    {


        //Arrange
        string input = "4 8 15";
        int[] expected = { 4, 8, 15 };
        //Act
        int[] result = Program.InputNumbers(input);

        //Assert
        Assert.Equal(result, expected);




    }

    [Fact]
    public void MultiplyNumbers_ThreeNumbers()
    {


        //Arrange
        int[] numbers = { 4, 8, 15 };
        int expected = 4 * 8 * 15;

        //Act
        int result = Program.Multiply(numbers);

        //Assert
        Assert.Equal(result, expected);
    }





    [Fact]
    public void MultiplyNumbers_MoreThanThreeNumbers_TakeFirstThree()
    {
        // Arrange
        int[] input = { 2, 4, 6, 8 };
        int expected = 2 * 4 * 6;

        // Act
        int result = Program.Multiply(input);

        // Assert
        Assert.Equal(result, expected);
    }



    [Fact]
    public void MultiplyNumbers_LessThanThreeNumbers_Zero()
    {
        // Arrange
        int[] input = { 2, 4 };
        int expected = 0;

        // Act
        int result = Program.Multiply(input);

        // Assert
        Assert.Equal(result, expected);
    }




    [Fact]
    public void MultiplyNumbers_NigativeNumbers()
    {
        // Arrange
        int[] input = { -2, 4, -6 };
        int expected = -2 * 4 * -6;

        // Act
        int result = Program.Multiply(input);

        // Assert
        Assert.Equal(expected, result);
    }





    //challenge2

    [Theory]
    [InlineData(4, new[] { 4, 8, 15, 16 }, 10)]
    [InlineData(3, new[] { 0, 0, 0 }, 0)] // All numbers are 0s
    [InlineData(6, new[] { 2, 4, 1, 18, 6, 9 }, 6)]
    public void GetAvg_DifferentRanges(int count, int[] inputNumbers, int expected)
    {
        var input = new System.IO.StringReader(string.Join(Environment.NewLine, inputNumbers));
        Console.SetIn(input);

        int actualAverage = Program.GetAvg();

        Assert.Equal(expected, actualAverage);
    }



    [Fact]
    public void GetAvg_InputOutOfRange()
    {
        // Arrange
        var inputMock = new System.IO.StringReader("11");
        System.Console.SetIn(inputMock);

        // Act
        int actualResult = Program.GetAvg();

        // Assert
        Assert.Equal(11, actualResult);
    }




  









    //challenge4

    [Fact]
    public void FrequentNumber_DifferentSizeArrays()
    {
        int[] arr1 = {  2, 2, 1, 1, 3, 3, 4, 4, 4 };
        int[] arr2 = { 6, 3, 3, 9 };
        int[] arr3 = { 5 };

        int mostFrequent1 = Program.FrequentNumber(arr1);
        int mostFrequent2 = Program.FrequentNumber(arr2);
        int mostFrequent3 = Program.FrequentNumber(arr3);

        Assert.Equal(4, mostFrequent1);
        Assert.Equal(3, mostFrequent2);
        Assert.Equal(5, mostFrequent3);
    }




    [Fact]
    public void FrequentNumber_AllSameNumbers()
    {
        int[] arr = { 3,3,3,3 };

        int mostFrequent = Program.FrequentNumber(arr);

        Assert.Equal(3, mostFrequent);
    }



    [Fact]
    public void FrequentNumber_NoDuplicates()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        int mostFrequent = Program.FrequentNumber(arr);

        Assert.Equal(1, mostFrequent);
    }




    [Fact]
    public void FrequentNumber_MultipleSameFrequencies() //There multiple numbers that show up the same amount of times.


    {
        int[] arr = {  3, 3, 3, 4, 4, 4 };

        int mostFrequent = Program.FrequentNumber(arr);

        Assert.Equal(3, mostFrequent);
    }


    //challenge 5

    [Fact]
    public void FindMax_NegativeNumbers()
    {
        int[] arr = { -5, -2, -9, -1, -7 };
        int maximumValue = Program.FindMax(arr);
        Assert.Equal(-1, maximumValue);
    }

    [Fact]
    public void FindMax_AllValuesSame()
    {
        int[] arr = { 3, 3, 3, 3, 3 };
        int maximumValue = Program.FindMax(arr);
        Assert.Equal(3, maximumValue);
    }








    //challenge 9

    [Fact]
    public void WordsLength_ReturnsCorrectArray()
    {
        // Arrange
        string sentence = "Let's test the function";
        var input = new StringReader(sentence);
        Console.SetIn(input);

        // Act
        string[] wordLengths = Program.WordsLength();

        // Assert
        Assert.Equal(new[]
        {
            "Let's: 5 ",
            "test: 4 ",
            "the: 3 ",
            "function: 8 "
        }, wordLengths);

       
       

     

    }




    [Fact]
    public void WordsLength_ReturnsArray()
    {
        // Arrange
        string sentence = "Hello World";
        var input = new StringReader(sentence);
        Console.SetIn(input);

        // Act
        string[] wordLengths = Program.WordsLength();

        // Assert
        Assert.NotNull(wordLengths);
        Assert.NotEmpty(wordLengths);
        Assert.Equal(2, wordLengths.Length);
    }






    [Fact]
    public void WordsLength_InputSentencesWithSymbols()
    {
        // Arrange
        string sentence1 = "I love coding!";
        string sentence2 = "test the method.";
        var inputMock1 = new StringReader(sentence1);
        var inputMock2 = new StringReader(sentence2);
        Console.SetIn(inputMock1);

        // Act
        string[] wordLengths1 = Program.WordsLength();
        Console.SetIn(inputMock2);
        string[] wordLengths2 = Program.WordsLength();

        // Assert
        Assert.Equal(new[]
        {
            "I: 1 ",
            "love: 4 ",
            "coding!: 7 "
        }, wordLengths1);

        Assert.Equal(new[]
        {
            "test: 4 ",
            "the: 3 ",
            "method.: 7 "
        }, wordLengths2);
    }

}







