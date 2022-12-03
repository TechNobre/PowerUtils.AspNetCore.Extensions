using FluentAssertions;
using PowerUtils.AspNetCore.Attributes;
using PowerUtils.AspNetCore.Extensions.Tests.Fakes;
using Xunit;

namespace PowerUtils.AspNetCore.Extensions.Tests.AttributesTests
{
    public class ResponseTypes4XXTests
    {
        [Fact]
        public void Attribute_Constructor_Response400Attribute()
        {
            // Arrange && Act
            var act = new Response400Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(400);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response401Attribute()
        {
            // Arrange && Act
            var act = new Response401Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(401);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response402Attribute()
        {
            // Arrange && Act
            var act = new Response402Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(402);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response403Attribute()
        {
            // Arrange && Act
            var act = new Response403Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(403);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response404Attribute()
        {
            // Arrange && Act
            var act = new Response404Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(404);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response405Attribute()
        {
            // Arrange && Act
            var act = new Response405Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(405);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response406Attribute()
        {
            // Arrange && Act
            var act = new Response406Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(406);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response407Attribute()
        {
            // Arrange && Act
            var act = new Response407Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(407);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response408Attribute()
        {
            // Arrange && Act
            var act = new Response408Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(408);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response409Attribute()
        {
            // Arrange && Act
            var act = new Response409Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(409);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response410Attribute()
        {
            // Arrange && Act
            var act = new Response410Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(410);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response411Attribute()
        {
            // Arrange && Act
            var act = new Response411Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(411);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response412Attribute()
        {
            // Arrange && Act
            var act = new Response412Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(412);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response413Attribute()
        {
            // Arrange && Act
            var act = new Response413Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(413);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response414Attribute()
        {
            // Arrange && Act
            var act = new Response414Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(414);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response415Attribute()
        {
            // Arrange && Act
            var act = new Response415Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(415);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response416Attribute()
        {
            // Arrange && Act
            var act = new Response416Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(416);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response417Attribute()
        {
            // Arrange && Act
            var act = new Response417Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(417);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response418Attribute()
        {
            // Arrange && Act
            var act = new Response418Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(418);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response422Attribute()
        {
            // Arrange && Act
            var act = new Response422Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(422);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response426Attribute()
        {
            // Arrange && Act
            var act = new Response426Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(426);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response428Attribute()
        {
            // Arrange && Act
            var act = new Response428Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(428);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response429Attribute()
        {
            // Arrange && Act
            var act = new Response429Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(429);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response431Attribute()
        {
            // Arrange && Act
            var act = new Response431Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(431);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }

        [Fact]
        public void Attribute_Constructor_Response451Attribute()
        {
            // Arrange && Act
            var act = new Response451Attribute(typeof(FakeResponse));


            // Assert
            act.StatusCode.Should()
                .Be(451);

            act.Type.Should()
                .Be(typeof(FakeResponse));
        }
    }
}
