using PowerUtils.Text.Tests;
using Xunit;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes.Tests;

public class ResponseTypes200Tests
{
    [Fact]
    public void Constructor_Response200OKAttribute()
    {
        // Arrange && Act
        var act = new Response200OKAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(200);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response201CreatedAttribute()
    {
        // Arrange && Act
        var act = new Response201CreatedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(201);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response202AcceptedAttribute()
    {
        // Arrange && Act
        var act = new Response202AcceptedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(202);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response203NonAuthoritativeAttribute()
    {
        // Arrange && Act
        var act = new Response203NonAuthoritativeAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(203);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response204NoContentAttribute()
    {
        // Arrange && Act
        var act = new Response204NoContentAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(204);

        act.Type.Should()
            .Be(typeof(void));
    }

    [Fact]
    public void Constructor_Response205ResetContentAttribute()
    {
        // Arrange && Act
        var act = new Response205ResetContentAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(205);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response206PartialContentAttribute()
    {
        // Arrange && Act
        var act = new Response206PartialContentAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(206);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response207MultiStatusAttribute()
    {
        // Arrange && Act
        var act = new Response207MultiStatusAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(207);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response208AlreadyReportedAttribute()
    {
        // Arrange && Act
        var act = new Response208AlreadyReportedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(208);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response226IMUsedAttribute()
    {
        // Arrange && Act
        var act = new Response226IMUsedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(226);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }
}
