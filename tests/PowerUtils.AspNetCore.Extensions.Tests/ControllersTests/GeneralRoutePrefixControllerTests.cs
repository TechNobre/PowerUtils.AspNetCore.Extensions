using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using PowerUtils.AspNetCore.Extensions.Tests.Config;
using Xunit;

namespace PowerUtils.AspNetCore.Extensions.Tests.ControllersTests
{
    [Collection(nameof(IntegrationApiTestsFixtureCollection))]
    public class GeneralRoutePrefixControllerTests
    {
        private readonly IntegrationTestsFixture _testsFixture;

        public GeneralRoutePrefixControllerTests(IntegrationTestsFixture testsFixture)
            => _testsFixture = testsFixture;



        [Fact]
        public async Task RouteWithoutTemplateInAttribute_Get_OK()
        {
            // Arrange && Act
            var act = await _testsFixture.Client.GetAsync("/samples/prefix");


            // Assert
            act.StatusCode.Should()
                .Be(HttpStatusCode.OK);
        }


        [Fact]
        public async Task RouteWithGeneralPrefix_Get_OK()
        {
            // Arrange && Act
            var act = await _testsFixture.Client.GetAsync("/samples/prefix/with-prefix");


            // Assert
            act.StatusCode.Should()
                .Be(HttpStatusCode.OK);
        }


        [Fact]
        public async Task RouteWithoutGeneralPrefix_Get_OK()
        {
            // Arrange && Act
            var act = await _testsFixture.Client.GetAsync("/without-prefix");


            // Assert
            act.StatusCode.Should()
                .Be(HttpStatusCode.OK);
        }
    }
}
