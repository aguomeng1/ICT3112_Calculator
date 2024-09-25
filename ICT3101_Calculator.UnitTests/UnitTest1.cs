using ICT3112_Calculator;
namespace ICT3112_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToProduct()
        {
            // Act
            double result = _calculator.Multiply(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Divide_WithNonZeroInputs_ReturnsCorrectResult()
        {
            double result = _calculator.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        //[Test]
        //[TestCase(0, 0)]
        //[TestCase(0, 10)]
        //[TestCase(10, 0)]
        //public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        //{
        //Assert.That(() => _calculator.Divide(a, b), is.EqualTo(1));
        //}

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        [TestCase(10, 3628800)]
        public void Factorial_WithValidInputs_ReturnsCorrectResult(int input, long expected)
        {
            long result = _calculator.Factorial(input);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Factorial_WithNegativeInput_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1));
            Assert.That(ex.Message, Is.EqualTo("Factorial is not defined for negative numbers."));
        }

        [Test]
        public void Factorial_WithLargeInput_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => _calculator.Factorial(21));
            Assert.That(ex.Message, Is.EqualTo("Input too large. Maximum allowed input is 20."));
        }

        [Test]
        [TestCase(4, 3, 6)]  // Basic case
        [TestCase(5, 8, 20)] // Different numbers
        [TestCase(1, 1, 0.5)] // Small numbers
        [TestCase(100, 50, 2500)] // Large numbers
        public void TriangleArea_WithValidInputs_ReturnsCorrectResult(double height, double length, double expectedArea)
        {
            double result = _calculator.TriangleArea(height, length);
            Assert.That(result, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        [TestCase(0, 5)]
        [TestCase(5, 0)]
        [TestCase(-1, 5)]
        [TestCase(5, -1)]
        public void TriangleArea_WithInvalidInputs_ThrowsArgumentException(double height, double length)
        {
            Assert.Throws<ArgumentException>(() => _calculator.TriangleArea(height, length));
        }

        [Test]
        [TestCase(1, Math.PI)]
        [TestCase(2, Math.PI * 4)]
        [TestCase(0.5, Math.PI * 0.25)]
        [TestCase(10, Math.PI * 100)]
        public void CircleArea_WithValidInputs_ReturnsCorrectResult(double radius, double expectedArea)
        {
            double result = _calculator.CircleArea(radius);
            Assert.That(result, Is.EqualTo(expectedArea).Within(0.0001));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CircleArea_WithInvalidInputs_ThrowsArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => _calculator.CircleArea(radius));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void GenMagicNum_WhenGivenPos_ReturnCorrectResult ()
        {
            Assert.That(() => _calculator.GenMagicNum(1, _fileReader), Is.EqualTo(2));
        }

        [Test]
        public void GenMagicNum_WhenGivenNeg_ReturnCorrectResult()
        {
            Assert.That(() => _calculator.GenMagicNum(-1, _fileReader), Is.EqualTo(2));
        }

        [Test]
        public void GenMagicNum_WhenGivenZero_ReturnCorrectResult()
        {
            Assert.That(() => _calculator.GenMagicNum(0, _fileReader), Is.EqualTo(0));
        }
    }
}