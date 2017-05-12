using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMaps.HomePage
{
    public static class HomePageAsserter
    {
        public static void AssertSiteIsLoaded(this HomePage page, string message)
        {
            Assert.AreEqual(message, page.URL);
        }
        public static void AssertDirectionButtonExsists(this HomePage page, string message)
        {
            Assert.IsTrue(page.DirectionButton.Displayed, message);
        }
        public static void AssertDirectionMenuIsLoaded(this HomePage page, string message)
        {
            Assert.IsTrue(page.DirectionMenu.Displayed, message);
        }
        public static void AssertTimeForTravelWithTransit(this HomePage page, string time)
        {
            Assert.AreEqual(time, page.TimeForTravelWithTransit.Text);
        }
        public static void AssertDistanceBetweenStartAndFinalLocationWithDriving(this HomePage page, string distance)
        {
            Assert.AreEqual(distance, page.DistanceBetweenStartAndFinalLocationWithDriving.Text);
        }
        public static void AssertDistanceBetweenStartAndFinalLocationWithWalking(this HomePage page, string distance)
        {
            Assert.AreEqual(distance, page.DistanceBetweenStartAndFinalLocationWithWalking.Text);
        }
        public static void AssertTimeBetweenStartAndFinalLocationWithWalking(this HomePage page, string time)
        {
            Assert.AreEqual(time, page.TimeBetweenStartAndFinalLocationWithWalking.Text);
        }
        public static void AssertHighestAltitudeBetweenStartAndFinalLocationWithCycling(this HomePage page, string altitude)
        {
            Assert.AreEqual(altitude, page.HighestAltitudeBetweenStartAndFinalLocationWithCycling.Text);
        }
        public static void AssertCheckButtonForSendingMessageDisplayed(this HomePage page, string message)
        {
            Assert.IsTrue(page.CheckButton.Displayed);
        }
        public static void AssertTimeScheduleIsCorrect(this HomePage page, string time)
        {
            Assert.AreEqual(time, page.TimeScheduleExplorer.GetAttribute("class"));
        }
        
    }
}
