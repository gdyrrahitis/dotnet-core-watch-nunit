# Watch NUnit tests in .NET Core
Related blog post can be found [here](http://codereform.com/blog/post/watch-nunit-tests-in-net-core/)

Sample to demonstrate .NET Core test watch with NUnit framework.

Using `Microsoft.DotNet.Watcher.Tools` to watch unit tests and provide parallel feedback.

The runner for NUnit test framework, compatible with .NET Core is `dotnet-test-nunit`.

## Instructions

### VS 2015
Build project. This will get `dotnet restore` running.

### CMD
Open each project and run a `dotnet-restore` command. Remember to be on root folder of the project, where the `project.json` file lives.

Either path you choose from the above you need to do the following:

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
