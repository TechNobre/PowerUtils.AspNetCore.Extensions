using PowerUtils.AspNetCore.Extensions.Attributes;
using PowerUtils.AspNetCore.Extensions.Tests.Fakes;

namespace PowerUtils.AspNetCore.Extensions.Tests.AttributesTests;

public class ResponseTypes4XXTests
{
    [Fact]
    public void Constructor_Response400BadRequestAttribute()
    {
        // Arrange && Act
        var act = new Response400BadRequestAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(400);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response401UnauthorizedAttribute()
    {
        // Arrange && Act
        var act = new Response401UnauthorizedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(401);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response402PaymentRequiredAttribute()
    {
        // Arrange && Act
        var act = new Response402PaymentRequiredAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(402);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response403ForbiddenAttribute()
    {
        // Arrange && Act
        var act = new Response403ForbiddenAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(403);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response404NotFoundAttribute()
    {
        // Arrange && Act
        var act = new Response404NotFoundAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(404);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response405MethodNotAllowedAttribute()
    {
        // Arrange && Act
        var act = new Response405MethodNotAllowedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(405);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response406NotAcceptableAttribute()
    {
        // Arrange && Act
        var act = new Response406NotAcceptableAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(406);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response407ProxyAuthenticationRequiredAttribute()
    {
        // Arrange && Act
        var act = new Response407ProxyAuthenticationRequiredAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(407);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response408RequestTimeoutAttribute()
    {
        // Arrange && Act
        var act = new Response408RequestTimeoutAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(408);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response409ConflictAttribute()
    {
        // Arrange && Act
        var act = new Response409ConflictAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(409);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response410GoneAttribute()
    {
        // Arrange && Act
        var act = new Response410GoneAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(410);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response411LengthRequiredAttribute()
    {
        // Arrange && Act
        var act = new Response411LengthRequiredAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(411);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response412PreconditionFailedAttribute()
    {
        // Arrange && Act
        var act = new Response412PreconditionFailedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(412);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response413RequestEntityTooLargeAttribute()
    {
        // Arrange && Act
        var act = new Response413RequestEntityTooLargeAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(413);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response414RequestUriTooLongAttribute()
    {
        // Arrange && Act
        var act = new Response414RequestUriTooLongAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(414);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response415UnsupportedMediaTypeAttribute()
    {
        // Arrange && Act
        var act = new Response415UnsupportedMediaTypeAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(415);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response416RequestedRangeNotSatisfiableAttribute()
    {
        // Arrange && Act
        var act = new Response416RequestedRangeNotSatisfiableAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(416);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response417ExpectationFailedAttribute()
    {
        // Arrange && Act
        var act = new Response417ExpectationFailedAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(417);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response418ImATeapotAttribute()
    {
        // Arrange && Act
        var act = new Response418ImATeapotAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(418);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response422UnprocessableEntityAttribute()
    {
        // Arrange && Act
        var act = new Response422UnprocessableEntityAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(422);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response426UpgradeRequiredAttribute()
    {
        // Arrange && Act
        var act = new Response426UpgradeRequiredAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(426);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response428PreconditionRequiredAttribute()
    {
        // Arrange && Act
        var act = new Response428PreconditionRequiredAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(428);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response429TooManyRequestsAttribute()
    {
        // Arrange && Act
        var act = new Response429TooManyRequestsAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(429);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response431RequestHeaderFieldsTooLargeAttribute()
    {
        // Arrange && Act
        var act = new Response431RequestHeaderFieldsTooLargeAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(431);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }

    [Fact]
    public void Constructor_Response451UnavailableForLegalReasonsAttribute()
    {
        // Arrange && Act
        var act = new Response451UnavailableForLegalReasonsAttribute(typeof(FakeResponse));


        // Assert
        act.StatusCode.Should()
            .Be(451);

        act.Type.Should()
            .Be(typeof(FakeResponse));
    }
}
