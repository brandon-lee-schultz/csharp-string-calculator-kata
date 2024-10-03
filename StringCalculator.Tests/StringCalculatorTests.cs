using Moq;
using String_Calculator_Kata.Exceptions;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void Add_EmptyStringAsParams_ShouldReturnZero()
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();
            var expected = 0;

            //Act
            var result = calculator.Add("");

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(SingleDigitStubData))]
        public void Add_SingleDigitStringAsParams_ShouldReturnSingleDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(DoubleDigitStubData))]
        public void Add_DoubleDigitStringAsParams_ShouldReturnSumOfDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(DoubleDigitNewLineStubData))]
        public void Add_DoubleDigitWithNewLineDelimiterStringAsParams_ShouldReturnSumOfDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(DoubleDigitCustomDelimiterStubData))]
        public void Add_DoubleDigitWithCustomDelimiterStringAsParams_ShouldReturnSumOfDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(SingleNegativeDigitStubData))]
        public void Add_SingleNegativeDigitStringAsParams_ShouldThrowException(string numbers)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Assert
            var result = Assert.Throws<NegativeNumberException>(() =>
            {
                //Act
                calculator.Add(numbers);
            }).Message;

            Assert.Equal($"negatives not allowed: {numbers}", result);
        }

        [Theory]
        [ClassData(typeof(DoubleNegativeDigitStubData))]
        public void Add_DoubleNegativeDigitStringAsParams_ShouldReturnSumOfDigit(string numbers)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Assert
            var result = Assert.Throws<NegativeNumberException>(() =>
            {
                //Act
                calculator.Add(numbers);
            }).Message;

            Assert.Equal($"negatives not allowed: {numbers}", result);

        }

        [Fact]
        public void GetCalledCount_GivenParamsForAdd_ShouldReturnTotalCountAddGetsCalled()
        {
            //Arrange
            var callCountExpected = 4;
            var calculator = new String_Calculator_Kata.StringCalculator();
            
            //Act
            calculator.Add("1");
            calculator.Add("2");
            calculator.Add("4");
            calculator.Add("12");

            var callCount = calculator.GetCalledCount();

            //Assert
            Assert.Equal(callCount, callCountExpected);
        }

        [Fact]
        public void AddOccured_TriggerAdd_ShouldTriggerEvent()
        {
            //Arrange
            var input = "1,2,3";
            var calculator = new String_Calculator_Kata.StringCalculator();
            
            var calcResult = 0;
            var calcInput = "";

            //Act
            calculator.AddOccured += delegate(string input, int result)
            {
                calcInput = input;
                calcResult = result;
            };

            calculator.Add(input);

            //Assert
            Assert.Equal(input, calcInput);
            Assert.Equal(6, calcResult);
        }

        [Theory]
        [ClassData(typeof(DoubleDigitGreaterThan1kCustomDelimiterStubData))]
        public void Add_DoubleDigitGreaterThan1kCustomDelimiterStringAsParams_ShouldReturnSumOfDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(DoubleDigitCustomLengthDelimiterStubData))]
        public void Add_DoubleDigitWithCustomLengthDelimiterStringAsParams_ShouldReturnSumOfDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(MultipleDelimitersWithCustomLengthStubData))]
        public void Add_MultipleDelimitersWithCustomLengthAsParams_ShouldReturnSumOfDigit(string numbers, int expected)
        {
            //Arrange
            var calculator = new String_Calculator_Kata.StringCalculator();

            //Act
            var result = calculator.Add(numbers);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}