using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using GoogleMaps.HomePage;
using OpenQA.Selenium.Support.UI;

namespace GoogleMapsTest
{
    [TestFixture]
    public class GoogleMapsTests
    {
        private IWebDriver driver;

        //Open Chrome browser
        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
            this.driver.Manage().Window.Maximize();
        }

        //Close Chrome browser
        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Open Chrome browser and check www.maps.google.com is loaded
        public void CheckSiteIsLoaded()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            homePage.AssertSiteIsLoaded("http://maps.google.com");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Open www.maps.google.com and check Directions button is visible
        public void CheckDirectionButtonDisplayed()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();

            homePage.AssertDirectionButtonExsists("Directions button is visible!");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Click to Directions button and check Direction view is loaded
        public void CheckDirectionViewIsLoaded()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();

            homePage.AssertDirectionMenuIsLoaded("Direction menu is loaded!");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Click to Transit button and check the time between start and final location
        public void CheckTheTimeBetweenStartAndFinalLocationWithTransit()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.TransitButton.Click();

            homePage.AssertTimeForTravelWithTransit("30 мин");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Click to Driving button and check the distance between start and final location
        public void CheckTheDistanceBetweenStartAndFinalLocationWithDriving()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.DrivingButton.Click();

            homePage.AssertDistanceBetweenStartAndFinalLocationWithDriving("4,6 мили");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Click to Walking button and check the distance and the time betwee start and final location
        public void CheckTheDistanceAndTheTimeBetweenStartAndFinalLocationWithWalking()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.WalkingButton.Click();

            homePage.AssertDistanceBetweenStartAndFinalLocationWithWalking("5,6 мили");
            homePage.AssertTimeBetweenStartAndFinalLocationWithWalking("1 ч 53 мин");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        //Click to Cycling button and check check the highest altitude
        public void CheckTheHighestAltitudeBetweenStartAndFinalLocationWithCycling()
        {
            var homePage = new HomePage(this.driver);
            homePage.NavigateTo();
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys("6480 Weathers Pl, San Diego, CA 92121, USA");
            homePage.FinalLocation.SendKeys("Bus Access Rd, San Diego, CA 92122, USA");
            homePage.CyclingButton.Click();

            homePage.AssertHighestAltitudeBetweenStartAndFinalLocationWithCycling("417 фута");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        // Send direction to your phone
        public void CheckSendDirectionToPhoneWithTransit()
        {
            var homePage = new HomePage(this.driver);
            var startLocation = "6480 Weathers Pl, San Diego, CA 92121, USA";
            var finalLocation = "Bus Access Rd, San Diego, CA 92122, USA";
            homePage.NavigateTo();
            LoginGoogleMaps("xpucu91@gmail.com", "76a1512a");
            homePage.DirectionButton.Click();
            homePage.StartLocation.SendKeys(startLocation);
            homePage.FinalLocation.SendKeys(finalLocation);
            homePage.TransitButton.Click();
            homePage.SendingButton.Click();
            homePage.PhoneModel.Click();

            homePage.AssertCheckButtonForSendingMessageDisplayed("The message was send!");
        }

        [Test, Property("Priority", 1)]
        [Author("Hristinka Mineva")]

        // Open Schedule Explorer and check the time and the date
        public void CheckPlanAndScheduleToUser()
        {
            var homePage = new HomePage(this.driver);
            var startLocation = "6480 Weathers Pl, San Diego, CA 92121, USA";
            var finalLocation = "Bus Access Rd, San Diego, CA 92122, USA";
            var time = "9:33 AM";
            homePage.NavigateTo();
            LoginGoogleMaps("hristina.hrisi.mineva@gmail.com", "qwertyuiop789");
            homePage.DirectionButton.Click();
            Type(homePage.StartLocation, startLocation);
            Type(homePage.FinalLocation, finalLocation);
            homePage.TransitButton.Click();
            homePage.OptionButton.Click();
            homePage.CheckBusButton.Click();
            homePage.CheckTrainButton.Click();
            homePage.CheckFewerTransfersButton.Click();
            homePage.CloseButton.Click();
            homePage.LeaveNowDropDownButton.Click();
            homePage.LeaveNowDropDownMenu.Click();
            Type(homePage.TimeDropDownMenu, time);
            homePage.ScheduleExplorerButton.Click();

            homePage.AssertTimeScheduleIsCorrect(time);
        }
        private void LoginGoogleMaps(string email, string password)
        {
            var homePage = new HomePage(this.driver);
            if (homePage.LoginButton.Displayed)
            {
                homePage.LoginButton.Click();
                homePage.Email.SendKeys(email);
                homePage.EmailNextButton.Click();
                homePage.Password.SendKeys(password);
                homePage.PasswordNextButton.Click();
            }
        }
        private void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }
}
