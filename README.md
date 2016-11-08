# dotnet-core-watch-nunit
Sample to demonstrate .NET Core test watch with NUnit framework.

Using `Microsoft.DotNet.Watcher.Tools` to watch unit tests and provide parallel feedback.

The runner for NUnit test framework, compatible with .NET Core is `dotnet-test-nunit`.

## Instructions

On test project folder open a CMD window and type `dotnet watch test`. dotnet-test- runner will start running the tests and the watcher tools will watch tests and code under test for changes, providing feedback on console.

## Code

Author NUnit unit tests as usual.

```
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

```
