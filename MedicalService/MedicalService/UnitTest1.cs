using MedicalService.Driver;
using MedicalService.Page;

namespace MedicalService
{
    public class Tests
    {
        LoginPage loginPage;
        MedicalPage medicalPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            medicalPage = new MedicalPage();
        }

        [TearDown]

        [Test]
        public void Close()
        {
            WebDrivers.CleanUp();
        }


        [Test]
        public void TC01_MakeAppoIntment_ShouldAppoitmentBeCompleted()
        {
            loginPage.AppElement.Click();
            loginPage.Login("John Doe", "ThisIsNotPassword");
            medicalPage.SelectOption("Hongkong CURA Healthcare Centar");
            medicalPage.Checkbox.Click();
            medicalPage.MedicaId.Click();
            medicalPage.Date.SendKeys("Zakazano");
            medicalPage.Button.Submit();

            Assert.That("Appintment Confirmation", Is.EqualTo(medicalPage.Confirm.Text));
        }
    }
}