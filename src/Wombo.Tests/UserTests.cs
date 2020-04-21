using Wombo.Domain.Users;
using Xunit;

namespace Wombo.Tests
{
    public class UserTests
    {
        [Fact]
        public void ShouldMarkUserInvalidWhenPassInvalidData()
        {
            // arrange

            var user = new User(
                id: 1,
                nome: string.Empty,
                email: string.Empty
            );

            // act

            var isValid = user.IsValid();

            // asert

            Assert.False(isValid);
        }

        [Fact]
        public void ShouldMarkUserValidWhenPassValidData()
        {
            // arrange

            var user = new User(
                id: 1,
                nome: "Tiago",
                email: "tiago@email.com"
            );

            // act

            var isValid = user.IsValid();

            // asert

            Assert.True(isValid);
        }
    }
}