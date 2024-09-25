using Moq;
namespace ICT3112_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;
        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("../../../../Lab1_SetupUnits/MagicNumbers.txt")).Returns(new string[2] { "42", "42" });
            _calculator = new Calculator();
        }
        [Test]
        public void GenMagicNum_WhenGivenPosIndexAndMock_ReturnCorrectResult()
        {
            Assert.That(() => _calculator.GenMagicNum(1, _mockFileReader.Object), Is.EqualTo(84));
        }

        [Test]
        public void GenMagicNum_WhenGivenNegIndexAndMock_ReturnCorrectResult()
        {
            Assert.That(() => _calculator.GenMagicNum(-1, _mockFileReader.Object), Is.EqualTo(0));
        }

        [Test]
        public void GenMagicNum_WhenGivenIndexZeroAndMock_ReturnCorrectResult()
        {
            Assert.That(() => _calculator.GenMagicNum(0, _mockFileReader.Object), Is.EqualTo(84));
        }
    }
}
