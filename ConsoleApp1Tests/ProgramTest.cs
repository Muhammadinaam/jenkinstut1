using ConsoleApp1;
using NUnit.Framework;
using Shouldly;

namespace ConsoleApp1Tests
{
    /// <summary>
    /// Summary description for ProgramTest
    /// </summary>
    [TestFixture]
    public class ProgramTest
    {
        [Test]
        public void HelloMessage_WhenCalled_ReturnsHello()
        {
            // Act
            var result = Program.HelloMessage();

            // Assert
            result.ShouldBe("Hello");
        }
    }
}
