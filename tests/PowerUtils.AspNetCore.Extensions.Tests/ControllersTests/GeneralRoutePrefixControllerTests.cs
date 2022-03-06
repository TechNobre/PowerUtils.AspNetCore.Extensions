using System.Net;
using PowerUtils.AspNetCore.Extensions.Tests.Config;

namespace PowerUtils.AspNetCore.Extensions.Tests.ControllersTests;

[Collection(nameof(IntegrationApiTestsFixtureCollection))]
public class GeneralRoutePrefixControllerTests
{
    private readonly IntegrationTestsFixture _testsFixture;

    public GeneralRoutePrefixControllerTests(IntegrationTestsFixture testsFixture)
        => _testsFixture = testsFixture;


    [Fact(DisplayName = "Send request to endpoint without attribute")]
    public async void Route_WithoutAttribute()
    {
        // Arrange && Act
        var act = await _testsFixture.Client.GetAsync("/samples/prefix");


        // Assert
        act.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }


    [Fact(DisplayName = "Send request to endpoint with general prefix")]
    public async void Route_WithGeneralPrefix()
    {
        // Arrange && Act
        var act = await _testsFixture.Client.GetAsync("/samples/prefix/with-prefix");


        // Assert
        act.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }


    [Fact(DisplayName = "Send request to endpoint without general prefix")]
    public async void Route_WithoutGeneralPrefix()
    {
        // Arrange && Act
        var act = await _testsFixture.Client.GetAsync("/without-prefix");


        // Assert
        act.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }
}
