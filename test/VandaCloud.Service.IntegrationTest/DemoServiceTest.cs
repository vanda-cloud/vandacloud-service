using DAD.CoreService.Service.Demo;
using DAD.CoreService.Service.DemoHello;
using Microsoft.Extensions.DependencyInjection;

namespace DAD.CoreService.IntegrationTest
{
    public class DemoServiceTest
    {
        private IDemoService? demoService;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection();
            services.AddScoped<IDemoService, DemoService>();
            services.AddScoped<IDemoHelloService, DemoHelloService>();

            var serviceProvider = services.BuildServiceProvider();
            demoService = serviceProvider.GetService<IDemoService>();
        }

        [Test]
        public void T001_Wellcome()
        {
            /// Arrange
            string expected = "Hello everyone! Welcome to Vanda-Cloud Development Project.";

            // Act
            string? actual = demoService?.Welcome();

            // Assert
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual, Is.EqualTo(expected));

        }
    }
}