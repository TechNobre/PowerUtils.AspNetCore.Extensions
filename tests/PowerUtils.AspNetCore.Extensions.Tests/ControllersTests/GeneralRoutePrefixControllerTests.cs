using System.Net;
using PowerUtils.AspNetCore.Extensions.Tests.Config;

namespace PowerUtils.AspNetCore.Extensions.Tests.ControllersTests;

[Collection(nameof(IntegrationApiTestsFixtureCollection))]
public class GeneralRoutePrefixControllerTests
{
    private readonly IntegrationTestsFixture _testsFixture;

    public GeneralRoutePrefixControllerTests(IntegrationTestsFixture testsFixture)
        => _testsFixture = testsFixture;



    [Fact]
    public async void RouteWithoutAttribute_Class_OK()
    {
        // Arrange && Act
        var act = await _testsFixture.Client.GetAsync("/samples/prefix");


        // Assert
        act.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }


    [Fact]
    public async void RouteWithGeneralPrefix_Class_OK()
    {
        // Arrange && Act
        var act = await _testsFixture.Client.GetAsync("/samples/prefix/with-prefix");


        // Assert
        act.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }


    [Fact]
    public async void RouteWithoutGeneralPrefix_Class_OK()
    {
        // Arrange && Act
        var act = await _testsFixture.Client.GetAsync("/without-prefix");


        // Assert
        act.StatusCode.Should()
            .Be(HttpStatusCode.OK);
    }
}
