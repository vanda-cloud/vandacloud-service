using DAD.CoreService.Service.DemoHello;
using Microsoft.Extensions.DependencyInjection;

namespace DAD.CoreService.UnitTest
{
    public class DemoHelloServiceTest
    {
        private readonly IDemoHelloService? demoHelloService;

        public DemoHelloServiceTest()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDemoHelloService, DemoHelloService>();

            var serviceProvider = services.BuildServiceProvider();
            demoHelloService = serviceProvider.GetService<IDemoHelloService>();
        }


        [Fact]
        public void T001_GetHello()
        {
            // Arrange
            string expected = "Hello everyone!";

            // Act
            string? actual = demoHelloService?.GetHello();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}