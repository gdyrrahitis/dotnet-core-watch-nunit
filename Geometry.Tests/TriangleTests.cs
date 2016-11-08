namespace Geometry.Tests
{
    using NUnit.Framework;
    using static NUnit.Framework.Assert;

    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Triangle_Area_OfSixBaseAndThreeHeight_IsNine_Test()
        {
            // Arrange
            const double @base = 6;
            const double height = 3;
            var triangle = new Triangle();

            // Act
            var result = triangle.Area(@base, height);

            // Assert
            AreEqual(9.0d, result);
        }
    }
}
