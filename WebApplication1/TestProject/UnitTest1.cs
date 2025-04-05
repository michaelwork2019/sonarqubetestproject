using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;
using Moq;
using WebApplication2.Pages;

namespace TestProject
{
    public class Tests
    {
        private HttpClient _client;

        [SetUp]
        public void Setup()
        {
            //var factory = new WebApplicationFactory<MyRazorApp.Startup>();
            //_client = factory.CreateClient();
        }

        [Test]
        public void Test1()
        {
            var mocklogger = new Mock<ILogger<IndexModel>>();
            var pagemodel = new IndexModel(mocklogger.Object);
            pagemodel.OnGet();
            Assert.AreEqual("You are good.", pagemodel.message);
        }
    }
}