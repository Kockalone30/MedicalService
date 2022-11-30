using MedicalService.Driver;
using MedicalService.Page;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace MedicalService.Tests
{
    internal class LoginTest
    {
        LoginPage loginPage;


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();

        }

        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUp();

        }

        [Test]
        public void TC01_EnterInvalidUserName()
        {
            loginPage.AppElement.Click();
            loginPage.Login("Dusan", "ThisIsNotPassword");

            Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.Message.Text));
        }
        [Test]
        public void TC02_EnterInvalidUserName()
        {
            loginPage.AppElement.Click();
            loginPage.Login("Dusan", "ThisIsNotPassword");

            Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.Message.Text));
        }

        [Test]
        public void TC03_EnterNoData()
        {
            loginPage.AppElement.Click();
            loginPage.Login("", "");

            Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.Message.Text));
         }
    }
}
