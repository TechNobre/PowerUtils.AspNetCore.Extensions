using PowerUtils.AspNetCore.Attributes;
using PowerUtils.AspNetCore.Extensions.Tests.Fakes;

namespace PowerUtils.AspNetCore.Extensions.Tests.AttributesTests;

public class ResponseTypes2XXTests
{
    [Fact]
    public void Constructor_WithoutType_Response200Attribute()
    {
        // Arrange && Act
        var act = new Response200Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(200);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response200Attribute()
    {
        // Arrange && Act
        var act = new Response200Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(200);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response201Attribute()
    {
        // Arrange && Act
        var act = new Response201Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(201);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response201Attribute()
    {
        // Arrange && Act
        var act = new Response201Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(201);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response202Attribute()
    {
        // Arrange && Act
        var act = new Response202Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(202);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response202Attribute()
    {
        // Arrange && Act
        var act = new Response202Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(202);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response203Attribute()
    {
        // Arrange && Act
        var act = new Response203Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(203);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response203Attribute()
    {
        // Arrange && Act
        var act = new Response203Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(203);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response204Attribute()
    {
        // Arrange && Act
        var act = new Response204Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(204);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithoutType_Response205Attribute()
    {
        // Arrange && Act
        var act = new Response205Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(205);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response205Attribute()
    {
        // Arrange && Act
        var act = new Response205Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(205);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response206Attribute()
    {
        // Arrange && Act
        var act = new Response206Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(206);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response206Attribute()
    {
        // Arrange && Act
        var act = new Response206Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(206);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response207Attribute()
    {
        // Arrange && Act
        var act = new Response207Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(207);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response207Attribute()
    {
        // Arrange && Act
        var act = new Response207Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(207);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response208Attribute()
    {
        // Arrange && Act
        var act = new Response208Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(208);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response208Attribute()
    {
        // Arrange && Act
        var act = new Response208Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(208);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_WithoutType_Response226Attribute()
    {
        // Arrange && Act
        var act = new Response226Attribute();


        // Assert
        act.StatusCode.Should()
            .Be(226);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_WithType_Response226Attribute()
    {
        // Arrange && Act
        var act = new Response226Attribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(226);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }
}
