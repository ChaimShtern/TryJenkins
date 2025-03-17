using System;
using System.IO;
using TryJenkins;
using Xunit;

public class PersonTests
{
    [Fact]
    public void Print_PrintsCorrectFormat()
    {
        // Arrange
        var person = new Person { FirstName = "John", LastName = "Doe", Age = 30, Id = 99 };
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        person.Print();

        // Assert
        var output = sw.ToString().Trim();
        var expectedOutput = "{\n  id: 99,\n  full name: John Doe,\n  age: 30,\n}";
        Assert.Equal(expectedOutput, output);
    }
}
