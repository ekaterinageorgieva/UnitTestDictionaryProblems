using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int> 
        {
            ["orange"]= 8,
            ["kiwi"]= 12
        };
        string currentFruit = "kiwi";

        // Act
        var result = Fruits.GetFruitQuantity(fruit, currentFruit);

        // Assert
        Assert.That(result, Is.EqualTo(12));

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int>
        {
            ["orange"] = 8,
            ["kiwi"] = 12
        };
        string currentFruit = "apple";

        // Act
        var result = Fruits.GetFruitQuantity(fruit, currentFruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));

    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int>();
        string currentFruit = "kiwi";

        // Act
        var result = Fruits.GetFruitQuantity(fruit, currentFruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = null;
        string currentFruit = "kiwi";

        // Act
        var result = Fruits.GetFruitQuantity(fruit, currentFruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int> fruit = new Dictionary<string, int>
        {
            ["lemon"] = 2,
            ["orange"] = 5
        }; ;
        string currentFruit = null;

        // Act
        var result = Fruits.GetFruitQuantity(fruit, currentFruit);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
}
