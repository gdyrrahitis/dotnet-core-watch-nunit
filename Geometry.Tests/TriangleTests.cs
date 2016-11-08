namespace Geometry.Tests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Triangle_Area_BySixMetersWidthAndThreeMetersHeight_IsEighteenSquareMeters_Test()
        {
            // Arrange
            const double width = 6;
            const double height = 3;
            var triangle = new Triangle();

            // Act
            var result = triangle.Area(width, height);

            // Assert
            AreEqual(18.0d, result);
        }
    }
}
