using Moq;
using Webdock.Factory;
using Webdock.Services;
using Webdock_Backend.Services;
namespace Webdock_Backend_UnitTests
{
    [TestClass]
    public class PingServiceTests
    {

        private Mock<WebdockHttpClientFactory> _mockFactory;
        private PingService _pingService;

        [TestInitialize]
        public void Setup()
        {
            // Create a mock instance of the WebdockHttpClientFactory
            _mockFactory = new Mock<WebdockHttpClientFactory>();


            // Use the mock instance when constructing the PingService
            _pingService = new PingService(_mockFactory.Object);
        }

        [TestMethod]
        public async Task GetPingAsync_ReturnsExpectedResponse()
        {
            // Arrange - Any additional setup

            // Act - Call the method to test
            var result = await _pingService.GetPingAsync();

            // Assert - Verify the result
            Assert.IsNotNull(result);
            // Additional assertions as needed
        }
    }
}