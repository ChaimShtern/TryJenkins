using System;
using System.Collections.Generic;
using TryJenkins;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class DataTests
{
    [Fact]
    public void GetPeople_ReturnsCorrectNumberOfPeople()
    {
        // Arrange
        var data = new Data();

        // Act
        List<Person> people = data.GetPeople();

        // Assert
        Assert.Equal(3, people.Count);
    }

    [Fact]
    public void GetPeople_ContainsSpecificPerson()
    {
        // Arrange
        var data = new Data();

        // Act
        List<Person> people = data.GetPeople();
        var person = people.Find(p => p.Id == 2);

        // Assert
        Assert.NotNull(person);
        Assert.Equal("Matanel", person.FirstName);
        Assert.Equal("Vatkin", person.LastName);
        Assert.Equal(24, person.Age);
    }
}
